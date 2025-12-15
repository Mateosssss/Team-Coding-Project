using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;

namespace Backend.Services.Interfaces
{
    public interface IAddonsService
    {
        public Task<AddonsDto> GetById(Guid id);
        public Task Create(CreateAddonsDto dto);
        public Task Update(Guid id, CreateAddonsDto dto);
        public Task Delete(Guid id);
    }
}