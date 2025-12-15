using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ProjektZespołówka.Data;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Services
{
    public class AuthService(AppDbContext context,IConfiguration configuration) : IAuthService
    {
        public async Task<TokenResponseDto> LoginAsync(UserDtoLogin request)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.email == request.Email);
            if (user is null)
            {
                return null;
            }
            if (new PasswordHasher<User>().VerifyHashedPassword(user, user.passwordHash, request.Password)
                == PasswordVerificationResult.Failed)
            {
                return null;
            }

            TokenResponseDto response = await CreateTokenResponse(user);
            return response;
        }

        private async Task<TokenResponseDto> CreateTokenResponse(User user)
        {
            return new TokenResponseDto
            {
                AccessToken = CreateToken(user),
                RefreshToken = await GenerateAndSaveRefreshTokenAsync(user)
            };
        }

        public async Task<User?> RegisterAsync(UserDtoRegister request)
        {
            if(await context.Users.AnyAsync(u => u.email == request.Email))
            {
                return null;
            }

            var user = new User();

            var hashPassword = new PasswordHasher<User>()
                .HashPassword(user,request.Password);
            user.email = request.Email;
            user.passwordHash=hashPassword;

            context.Users.Add(user);
            await context.SaveChangesAsync();
            return user;
        }
        public async Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request)
        {
            var user = await context.Users
                .FirstOrDefaultAsync(u =>
                u.RefreshToken == request.RefreshToken &&
                u.RefreshTokenExpiryTime > DateTime.UtcNow);

            if (user == null)
                return null;

            return await CreateTokenResponse(user);
        }

        private string GenereteRefreshToken()
        {
            var randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
        private async Task<string> GenerateAndSaveRefreshTokenAsync(User user)
        {
            var refreshToken=GenereteRefreshToken();
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(30);
            await context.SaveChangesAsync();
            return refreshToken;
        }
        private string CreateToken(User user)
        {
            var claims = new List<Claim>
            {
              new Claim(ClaimTypes.Name,user.email),
              new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
              new Claim(ClaimTypes.Role,user.role.ToString())
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(configuration["AppSettings:Token"]!)
            );

            var creds = new SigningCredentials(key,SecurityAlgorithms.HmacSha512);

            var tokenDescriptor = new JwtSecurityToken(
                issuer:configuration["AppSettings:Issuer"],
                audience:configuration["AppSettings:Audience"],
                claims:claims,
                expires:DateTime.UtcNow.AddDays(1),
                signingCredentials:creds
            );

            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
    }
}