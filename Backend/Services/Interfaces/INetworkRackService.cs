using System;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Services.Interfaces
{
    public interface INetworkRackService : IGenericService<NetworkRack, NetworkRackDto, CreateNetworkRackDto>
    {
        /// <summary>
        /// Get network racks by project ID
        /// </summary>
        Task<IEnumerable<NetworkRackDto>> GetByProjectIdAsync(Guid projectId);
    }
}