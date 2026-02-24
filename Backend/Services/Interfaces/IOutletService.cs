using System;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Services.Interfaces
{
    public interface IOutletService : IGenericService<Outlet, OutletDto, CreateOutletDto>
    {
        /// <summary>
        /// Get outlets by room ID
        /// </summary>
        Task<IEnumerable<OutletDto>> GetByRoomIdAsync(Guid roomId);
    }
}