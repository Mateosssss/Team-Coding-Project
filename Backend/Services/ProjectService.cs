using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjektZespołówka.Data;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;
using ProjektZespołówka.Services.Interfaces;

namespace ProjektZespołówka.Services
{
    public class ProjectService : GenericService<Project, ProjectDto, CreateProjectDto>, IProjectService
    {
        public ProjectService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<ProjectDto>> GetByManagerIdAsync(Guid managerId)
        {
            return await FindAsync(p => p.ManagerId == managerId);
        }

        public async Task<IEnumerable<ProjectDto>> GetByLocationIdAsync(Guid locationId)
        {
            return await FindAsync(p => p.LocationId == locationId);
        }
    }
}
