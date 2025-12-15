using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;

namespace Backend.Services.Interfaces
{
    public interface IOutletService
    {
        public Task<OutletDto> GetById(Guid id);
        public Task Create(CreateOutletDto dto);
        public Task Update(Guid id, CreateOutletDto dto);
        public Task Delete(Guid id);
    }
}