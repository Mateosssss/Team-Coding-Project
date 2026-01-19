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
    public class LevelService : GenericService<Levels, LevelsDto, CreateLevelsDto>, ILevelsService
    {
        public LevelService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<LevelsDto>> GetByProjectIdAsync(Guid projectId)
        {
            return await FindAsync(l => l.ProjectId == projectId);
        }
    }
}
