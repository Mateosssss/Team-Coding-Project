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
    public class NetworkRackService : GenericService<NetworkRack, NetworkRackDto, CreateNetworkRackDto>, INetworkRackService
    {
        public NetworkRackService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<NetworkRackDto>> GetByProjectIdAsync(Guid projectId)
        {
            return await FindAsync(nr => nr.ProjectId == projectId);
        }
    }
}
