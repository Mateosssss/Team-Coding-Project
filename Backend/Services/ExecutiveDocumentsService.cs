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
    public class ExecutiveDocumentsService : GenericService<ExecutiveDocuments, ExecutiveDocumentsDto, CreateExecutiveDocumentsDto>, IExecutiveDocumentsService
    {
        public ExecutiveDocumentsService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
