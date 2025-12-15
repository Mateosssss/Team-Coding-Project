using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;

namespace Backend.Services.Interfaces
{
    public interface INetworkRackService
    {
        public Task<NetworkRackDto> GetById(Guid id);
        public Task Create(CreateNetworkRackDto dto);
        public Task Update(Guid id, CreateNetworkRackDto dto);
        public Task Delete(Guid id);
    }
}