using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;

namespace Backend.Services
{
    public interface IWorkStageService
    {
        public Task<WorkStagesDto> GetById(Guid id);
        public Task Create(CreateWorkStagesDto dto);
        public Task Update(Guid id, CreateWorkStagesDto dto);
        public Task Delete(Guid id);
    }
}