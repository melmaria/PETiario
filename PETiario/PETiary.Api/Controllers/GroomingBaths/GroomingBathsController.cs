
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PETiario.PETiary.Application.GroomingBaths.Dtos.Requests;
using PETiario.PETiary.Application.GroomingBaths.Dtos.Responses;
using PETiario.PETiary.Application.GroomingBaths.Services.Interfaces;

namespace PETiario.PETiary.Api.Controllers.GroomingBaths
{
    [Route("groomingBath")]
    public class GroomingBathsController(IGroomingBathApplication groomingBathApplication) : Controller
    {

        /// <summary>
        /// Create an groomingbath
        /// </summary>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateAsync([FromBody] GroomingBathsRequest request, CancellationToken cancellationToken = default)
        {
            await groomingBathApplication.CreateAsync(request, cancellationToken);
            return Ok();
        }

        /// <summary>
        /// Update an existing groomingbath
        /// </summary>
        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<GroomingBathsResponse>> UpdateAsync(int id, [FromBody] GroomingBathsRequest request, CancellationToken cancellationToken = default)
        {
            var updated = await groomingBathApplication.UpdateAsync(id, request, cancellationToken);
            return Ok(updated);
        }

        /// <summary>
        /// Delete an existing groomingbath
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            await groomingBathApplication.DeleteAsync(id, cancellationToken);
            return NoContent();
        }

        /// <summary>
        /// List all groomingbath
        /// </summary>
        [HttpGet]
        [Authorize]
        [ResponseCache(Duration = 3600)]
        public async Task<ActionResult<IEnumerable<GroomingBathsResponse>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var list = await groomingBathApplication.GetAllAsync(cancellationToken);
            return Ok(list);
        }

        /// <summary>
        /// Get an groomingbath by id
        /// </summary>
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<GroomingBathsResponse>> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var groomingBaths = await groomingBathApplication.GetByIdAsync(id, cancellationToken);
            return Ok(groomingBaths);
        }
    }
}