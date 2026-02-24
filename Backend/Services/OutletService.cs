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
    public class OutletService : GenericService<Outlet, OutletDto, CreateOutletDto>, IOutletService
    {
        public OutletService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<OutletDto>> GetByRoomIdAsync(Guid roomId)
        {
            return await FindAsync(o => o.RoomId == roomId);
        }
    }
}
