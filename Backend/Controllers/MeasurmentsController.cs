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
    public class MeasurmentsController : ControllerBase
    {
        private readonly IMeasurmentsService _service;

        public MeasurmentsController(IMeasurmentsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MeasurmentsDto>>> GetAll()
        {
            var measurments = await _service.GetAllAsync();
            return Ok(measurments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MeasurmentsDto>> GetById(Guid id)
        {
            var measurment = await _service.GetByIdAsync(id);
            if (measurment == null)
                return NotFound();
            return Ok(measurment);
        }

        [HttpPost]
        public async Task<ActionResult<MeasurmentsDto>> Create(CreateMeasurmentsDto dto)
        {
            var measurment = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = measurment.Id }, measurment);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MeasurmentsDto>> Update(Guid id, CreateMeasurmentsDto dto)
        {
            try
            {
                var measurment = await _service.UpdateAsync(id, dto);
                return Ok(measurment);
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
