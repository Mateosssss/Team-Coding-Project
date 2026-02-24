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
    public class LocalizationsController : ControllerBase
    {
        private readonly ILocalizationService _service;

        public LocalizationsController(ILocalizationService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocalizationDto>>> GetAll()
        {
            var localizations = await _service.GetAllAsync();
            return Ok(localizations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LocalizationDto>> GetById(Guid id)
        {
            var localization = await _service.GetByIdAsync(id);
            if (localization == null)
                return NotFound();
            return Ok(localization);
        }

        [HttpPost]
        public async Task<ActionResult<LocalizationDto>> Create(CreateLocalizationDto dto)
        {
            var localization = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = localization.Id }, localization);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<LocalizationDto>> Update(Guid id, CreateLocalizationDto dto)
        {
            try
            {
                var localization = await _service.UpdateAsync(id, dto);
                return Ok(localization);
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
