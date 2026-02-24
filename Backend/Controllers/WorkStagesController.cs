using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Services.Interfaces;

namespace ProjektZespołówka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WorkStagesController : ControllerBase
    {
        private readonly IWorkStagesService _service;

        public WorkStagesController(IWorkStagesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkStagesDto>>> GetAll()
        {
            var stages = await _service.GetAllAsync();
            return Ok(stages);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkStagesDto>> GetById(Guid id)
        {
            var stage = await _service.GetByIdAsync(id);
            if (stage == null)
                return NotFound();
            return Ok(stage);
        }

        [HttpPost]
        public async Task<ActionResult<WorkStagesDto>> Create(CreateWorkStagesDto dto)
        {
            var stage = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = stage.Id }, stage);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WorkStagesDto>> Update(Guid id, CreateWorkStagesDto dto)
        {
            try
            {
                var stage = await _service.UpdateAsync(id, dto);
                return Ok(stage);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
