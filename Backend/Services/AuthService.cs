using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Services
{
    public class AuthService(
        UserManager<User> userManager,
        SignInManager<User> signInManager,
        IConfiguration configuration) : IAuthService
    {
        public async Task<TokenResponseDto?> LoginAsync(UserDtoLogin request)
        {
            var user = await userManager.FindByEmailAsync(request.Email);
            if (user is null) return null;

            var result = await signInManager.CheckPasswordSignInAsync(user, request.Password, lockoutOnFailure: false);

            if (!result.Succeeded) return null;

            return await CreateTokenResponse(user);
        }

    public async Task<User?> RegisterAsync(UserDtoRegister request)
    {
       var existingUser = await userManager.FindByEmailAsync(request.Email);
       if (existingUser != null) return null;

       var user = new User 
       { 
           Email = request.Email, 
           UserName = request.Email, 
           Name_Surname = request.Name_Surname,
           createdAt = DateTime.UtcNow,

           role = Helpers.UserRole.ServiceWorker 
       };

      
       var result = await userManager.CreateAsync(user, request.Password);

       if (!result.Succeeded)
       {
           return null;
       }

       return user;
    }

        public async Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request)
        {
            var user = userManager.Users.FirstOrDefault(u => 
                u.RefreshToken == request.RefreshToken && 
                u.RefreshTokenExpiryTime > DateTime.UtcNow);

            if (user == null) return null;

            return await CreateTokenResponse(user);
        }

        private async Task<TokenResponseDto> CreateTokenResponse(User user)
        {
            return new TokenResponseDto
            {
                AccessToken = await CreateToken(user),
                RefreshToken = await GenerateAndSaveRefreshTokenAsync(user)
            };
        }

        private async Task<string> GenerateAndSaveRefreshTokenAsync(User user)
        {
            var randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            var refreshToken = Convert.ToBase64String(randomNumber);

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7);

            await userManager.UpdateAsync(user);
            
            return refreshToken;
        }

        private async Task<string> CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email!),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.role.ToString())
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(configuration["AppSettings:Token"]!)
            );

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var tokenDescriptor = new JwtSecurityToken(
                issuer: configuration["AppSettings:Issuer"],
                audience: configuration["AppSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(15),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
    }
}