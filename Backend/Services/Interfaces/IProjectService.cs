using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.DTOs.Create;
using ProjektZespołówka.DTOs;

namespace Backend.Services.Interfaces
{
    public interface IProjectService
    {
        public Task<ProjectDto> GetById(Guid id);
        public Task Create(CreateProjectDto dto);
        public Task Update(Guid id, CreateProjectDto dto);
        public Task Delete(Guid id);
    }
}