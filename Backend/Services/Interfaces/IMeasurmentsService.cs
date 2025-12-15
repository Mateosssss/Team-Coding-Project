using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;

namespace Backend.Services.Interfaces
{
    public interface IMeasurmentsService
    {
        public Task<MeasurmentsDto> GetById(Guid id);
        public Task Create(CreateMeasurmentsDto dto);
        public Task Update(Guid id, CreateMeasurmentsDto dto);
        public Task Delete(Guid id);
    }
}