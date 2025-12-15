using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;

namespace Backend.Services.Interfaces
{
    public interface ICommentsService
    {
        public Task<CommentsDto> GetById(Guid id);
        public Task Create(CreateCommentsDto dto);
        public Task Update(Guid id, CreateCommentsDto dto);
        public Task Delete(Guid id);
    }
}