using System;
using System.Threading.Tasks;
using AutoMapper;
using ProjektZespołówka.Data;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;
using ProjektZespołówka.Services.Interfaces;

namespace ProjektZespołówka.Services
{
    public class RoomService : GenericService<Room, RoomDto, CreateRoomDto>, IRoomService
    {
        public RoomService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<RoomDto>> GetByLevelIdAsync(Guid levelId)
        {
            return await FindAsync(r => r.LevelId == levelId);
        }
    }
}
