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
    public class RackPanelService : GenericService<RackPanel, RackPanelDto, CreateRackPanelDto>, IRackPanelService
    {
        public RackPanelService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<RackPanelDto>> GetByNetworkRackIdAsync(Guid networkRackId)
        {
            return await FindAsync(rp => rp.NetworkRackId == networkRackId);
        }
    }
}
