using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDtoRegister request);
        Task<TokenResponseDto> LoginAsync(UserDtoLogin request);
        Task<TokenResponseDto> RefreshTokenAsync(RefreshTokenRequestDto request);
    }
}