using System;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Services.Interfaces
{
    public interface IRoomService : IGenericService<Room, RoomDto, CreateRoomDto>
    {
        /// <summary>
        /// Get rooms by level ID
        /// </summary>
        Task<IEnumerable<RoomDto>> GetByLevelIdAsync(Guid levelId);
    }
}