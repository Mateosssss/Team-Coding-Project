using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;

namespace Backend.Services.Interfaces
{
    public interface IExecutiveDocumentsService
    {
        public Task<ExecutiveDocumentsDto> GetById(Guid id);
        public Task Create(CreateExecutiveDocumentsDto dto);
        public Task Update(Guid id, CreateExecutiveDocumentsDto dto);
        public Task Delete(Guid id);
    }
}