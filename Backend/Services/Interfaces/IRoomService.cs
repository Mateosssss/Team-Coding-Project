using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;

namespace Backend.Services.Interfaces
{
    public interface IRoomService
    {
        public Task<RoomDto> GetById(Guid id);
        public Task Create(CreateRoomDto dto);
        public Task Update(Guid id, CreateRoomDto dto);
        public Task Delete(Guid id);
    }
}