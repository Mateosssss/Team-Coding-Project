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
    public class LocalizationService : GenericService<Localization, LocalizationDto, CreateLocalizationDto>, ILocalizationService
    {
        public LocalizationService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
