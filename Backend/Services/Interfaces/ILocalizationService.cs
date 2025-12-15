using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;

namespace Backend.Services.Interfaces
{
    public interface ILocalizationService
    {
        public Task<LocalizationDto> GetById(Guid id);
        public Task Create(CreateLocalizationDto dto);
        public Task Update(Guid id, CreateLocalizationDto dto);
        public Task Delete(Guid id);
    }
}