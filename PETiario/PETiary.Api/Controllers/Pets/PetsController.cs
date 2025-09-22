
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PETiario.PETiary.Application.Pets.Dtos.Requests;
using PETiario.PETiary.Application.Pets.Dtos.Responses;
using PETiario.PETiary.Application.Pets.Services.Interfaces;

namespace PETiario.PETiary.Api.Controllers.Pets
{
   [Route("pets")]
    public class PetsController(IPetApplication petApplication) : Controller
    {

        /// <summary>
        /// Create an pet
        /// </summary>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateAsync([FromBody] PetsRequest request, CancellationToken cancellationToken = default)
        {
            await petApplication.CreateAsync(request, cancellationToken);
            return Ok();
        }

        /// <summary>
        /// Update an existing pet
        /// </summary>
        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<PetsResponse>> UpdateAsync(int id, [FromBody] PetsRequest request, CancellationToken cancellationToken = default)
        {
            var updated = await petApplication.UpdateAsync(id, request, cancellationToken);
            return Ok(updated);
        }

        /// <summary>
        /// Delete an existing pet
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            await petApplication.DeleteAsync(id, cancellationToken);
            return NoContent();
        }

        /// <summary>
        /// List all pets
        /// </summary>
        [HttpGet]
        [Authorize]
        [ResponseCache(Duration = 3600)]
        public async Task<ActionResult<IEnumerable<PetsResponse>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var list = await petApplication.GetAllAsync(cancellationToken);
            return Ok(list);
        }

        /// <summary>
        /// Get an pet by id
        /// </summary>
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<PetsResponse>> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var pet = await petApplication.GetByIdAsync(id, cancellationToken);
            return Ok(pet);
        }
    }
}