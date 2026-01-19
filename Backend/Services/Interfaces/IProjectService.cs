using System;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Services.Interfaces
{
    public interface IProjectService : IGenericService<Project, ProjectDto, CreateProjectDto>
    {
        /// <summary>
        /// Get projects by manager ID
        /// </summary>
        Task<IEnumerable<ProjectDto>> GetByManagerIdAsync(Guid managerId);

        /// <summary>
        /// Get projects by location ID
        /// </summary>
        Task<IEnumerable<ProjectDto>> GetByLocationIdAsync(Guid locationId);
    }
}