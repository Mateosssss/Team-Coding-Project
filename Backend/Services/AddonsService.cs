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
    public class AddonsService : GenericService<Addons, AddonsDto, CreateAddonsDto>, IAddonsService
    {
        public AddonsService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
