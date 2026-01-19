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
    public class RackPanelsController : ControllerBase
    {
        private readonly IRackPanelService _service;

        public RackPanelsController(IRackPanelService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RackPanelDto>>> GetAll()
        {
            var panels = await _service.GetAllAsync();
            return Ok(panels);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RackPanelDto>> GetById(Guid id)
        {
            var panel = await _service.GetByIdAsync(id);
            if (panel == null)
                return NotFound();
            return Ok(panel);
        }

        [HttpPost]
        public async Task<ActionResult<RackPanelDto>> Create(CreateRackPanelDto dto)
        {
            var panel = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = panel.Id }, panel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<RackPanelDto>> Update(Guid id, CreateRackPanelDto dto)
        {
            try
            {
                var panel = await _service.UpdateAsync(id, dto);
                return Ok(panel);
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

        [HttpGet("rack/{networkRackId}")]
        public async Task<ActionResult<IEnumerable<RackPanelDto>>> GetByNetworkRack(Guid networkRackId)
        {
            var panels = await _service.GetByNetworkRackIdAsync(networkRackId);
            return Ok(panels);
        }
    }
}
