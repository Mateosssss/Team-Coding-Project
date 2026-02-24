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
    public class ExecutiveDocumentsController : ControllerBase
    {
        private readonly IExecutiveDocumentsService _service;

        public ExecutiveDocumentsController(IExecutiveDocumentsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExecutiveDocumentsDto>>> GetAll()
        {
            var documents = await _service.GetAllAsync();
            return Ok(documents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExecutiveDocumentsDto>> GetById(Guid id)
        {
            var document = await _service.GetByIdAsync(id);
            if (document == null)
                return NotFound();
            return Ok(document);
        }

        [HttpPost]
        public async Task<ActionResult<ExecutiveDocumentsDto>> Create(CreateExecutiveDocumentsDto dto)
        {
            var document = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = document.Id }, document);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ExecutiveDocumentsDto>> Update(Guid id, CreateExecutiveDocumentsDto dto)
        {
            try
            {
                var document = await _service.UpdateAsync(id, dto);
                return Ok(document);
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
