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
    public class NetworkRacksController : ControllerBase
    {
        private readonly INetworkRackService _service;

        public NetworkRacksController(INetworkRackService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NetworkRackDto>>> GetAll()
        {
            var racks = await _service.GetAllAsync();
            return Ok(racks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NetworkRackDto>> GetById(Guid id)
        {
            var rack = await _service.GetByIdAsync(id);
            if (rack == null)
                return NotFound();
            return Ok(rack);
        }

        [HttpPost]
        public async Task<ActionResult<NetworkRackDto>> Create(CreateNetworkRackDto dto)
        {
            var rack = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = rack.Id }, rack);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<NetworkRackDto>> Update(Guid id, CreateNetworkRackDto dto)
        {
            try
            {
                var rack = await _service.UpdateAsync(id, dto);
                return Ok(rack);
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
        public async Task<ActionResult<IEnumerable<NetworkRackDto>>> GetByProject(Guid projectId)
        {
            var racks = await _service.GetByProjectIdAsync(projectId);
            return Ok(racks);
        }
    }
}
