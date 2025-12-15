using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;

namespace Backend.Services.Interfaces
{
    public interface ILevelsService
    {
        public Task<LevelsDto> GetById(Guid id);
        public Task Create(CreateLevelsDto dto);
        public Task Update(Guid id, CreateLevelsDto dto);
        public Task Delete(Guid id);
    }
}