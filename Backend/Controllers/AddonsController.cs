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
    public class AddonsController : ControllerBase
    {
        private readonly IAddonsService _service;

        public AddonsController(IAddonsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddonsDto>>> GetAll()
        {
            var addons = await _service.GetAllAsync();
            return Ok(addons);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AddonsDto>> GetById(Guid id)
        {
            var addon = await _service.GetByIdAsync(id);
            if (addon == null)
                return NotFound();
            return Ok(addon);
        }

        [HttpPost]
        public async Task<ActionResult<AddonsDto>> Create(CreateAddonsDto dto)
        {
            var addon = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = addon.Id }, addon);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AddonsDto>> Update(Guid id, CreateAddonsDto dto)
        {
            try
            {
                var addon = await _service.UpdateAsync(id, dto);
                return Ok(addon);
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
