using System;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Services.Interfaces
{
    public interface ILevelService : IGenericService<Levels, LevelsDto, CreateLevelsDto>
    {
        /// <summary>
        /// Get levels by project ID
        /// </summary>
        Task<IEnumerable<LevelsDto>> GetByProjectIdAsync(Guid projectId);
    }
}
