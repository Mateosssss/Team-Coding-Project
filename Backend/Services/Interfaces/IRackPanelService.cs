using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace Backend.Services.Interfaces
{
    public interface IRackPanelService
    {
        public Task<RackPanelDto> GetById(Guid id);
        public Task Create(CreateRackPanelDto dto);
        public Task Update(Guid id, CreateRackPanelDto dto);
        public Task Delete(Guid id);
    }
}