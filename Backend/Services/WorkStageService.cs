using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjektZespołówka.Data;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace Backend.Services
{
    public class WorkStageService : IWorkStageService
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;
        public WorkStageService(IMapper mapper,AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task Create(CreateWorkStagesDto dto)
        {
            var entity = _mapper.Map<WorkStages>(dto);
            _context.WorkStages.Add(entity);
            await  _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var stage = await _context.WorkStages.FirstAsync(x=>x.Id==id);
            _context.WorkStages.Remove(stage);
            await _context.SaveChangesAsync();
        }

        public async Task<WorkStagesDto> GetById(Guid id)
        {
            var stage = await _context.WorkStages.FirstAsync(x=>x.Id==id);
            return _mapper.Map<WorkStagesDto>(stage);
        }

        public async Task Update(Guid id, CreateWorkStagesDto dto)
        {
            var stage = await _context.WorkStages.FirstAsync(x=>x.Id==id);
            _mapper.Map(dto,stage);
            await _context.SaveChangesAsync();
        }
    }
}