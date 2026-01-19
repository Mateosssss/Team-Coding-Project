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
    public class OutletsController : ControllerBase
    {
        private readonly IOutletService _service;

        public OutletsController(IOutletService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OutletDto>>> GetAll()
        {
            var outlets = await _service.GetAllAsync();
            return Ok(outlets);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OutletDto>> GetById(Guid id)
        {
            var outlet = await _service.GetByIdAsync(id);
            if (outlet == null)
                return NotFound();
            return Ok(outlet);
        }

        [HttpPost]
        public async Task<ActionResult<OutletDto>> Create(CreateOutletDto dto)
        {
            var outlet = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = outlet.Id }, outlet);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<OutletDto>> Update(Guid id, CreateOutletDto dto)
        {
            try
            {
                var outlet = await _service.UpdateAsync(id, dto);
                return Ok(outlet);
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

        [HttpGet("room/{roomId}")]
        public async Task<ActionResult<IEnumerable<OutletDto>>> GetByRoom(Guid roomId)
        {
            var outlets = await _service.GetByRoomIdAsync(roomId);
            return Ok(outlets);
        }
    }
}
