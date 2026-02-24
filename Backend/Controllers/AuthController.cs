using Microsoft.AspNetCore.Mvc;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.Models;
using ProjektZespołówka.Services;

namespace ProjektZespołówka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDtoRegister request)
        {
            try
            {
                var user = await authService.RegisterAsync(request);
                
                if (user == null)
                {
                    return BadRequest("Rejestracja nie powiodła się. Użytkownik może już istnieć.");
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest($"Błąd: {ex.Message}");
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<TokenResponseDto>> Login(UserDtoLogin request)
        {
            var result = await authService.LoginAsync(request);

            if (result == null)
            {
                return Unauthorized("Nieprawidłowy adres e-mail lub hasło.");
            }

            return Ok(result);
        }

        [HttpPost("refresh-token")]
        public async Task<ActionResult<TokenResponseDto>> RefreshToken(RefreshTokenRequestDto request)
        {
            var result = await authService.RefreshTokenAsync(request);

            if (result == null)
            {
                return Unauthorized("Nieprawidłowy lub wygasły token odświeżania.");
            }

            return Ok(result);
        }
    }
}