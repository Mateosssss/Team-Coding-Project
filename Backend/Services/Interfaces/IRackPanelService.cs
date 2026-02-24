using System;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Services.Interfaces
{
    public interface IRackPanelService : IGenericService<RackPanel, RackPanelDto, CreateRackPanelDto>
    {
        /// <summary>
        /// Get rack panels by network rack ID
        /// </summary>
        Task<IEnumerable<RackPanelDto>> GetByNetworkRackIdAsync(Guid networkRackId);
    }
}