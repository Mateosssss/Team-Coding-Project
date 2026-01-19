using System;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Services.Interfaces
{
    public interface ILocalizationService : IGenericService<Localization, LocalizationDto, CreateLocalizationDto>
    {
    }
}