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
    public class LevelsController : ControllerBase
    {
        private readonly ILevelService _service;

        public LevelsController(ILevelService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LevelsDto>>> GetAll()
        {
            var levels = await _service.GetAllAsync();
            return Ok(levels);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LevelsDto>> GetById(Guid id)
        {
            var level = await _service.GetByIdAsync(id);
            if (level == null)
                return NotFound();
            return Ok(level);
        }

        [HttpPost]
        public async Task<ActionResult<LevelsDto>> Create(CreateLevelsDto dto)
        {
            var level = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = level.Id }, level);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<LevelsDto>> Update(Guid id, CreateLevelsDto dto)
        {
            try
            {
                var level = await _service.UpdateAsync(id, dto);
                return Ok(level);
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

        [HttpGet("project/{projectId}")]
        public async Task<ActionResult<IEnumerable<LevelsDto>>> GetByProject(Guid projectId)
        {
            var levels = await _service.GetByProjectIdAsync(projectId);
            return Ok(levels);
        }
    }
}
