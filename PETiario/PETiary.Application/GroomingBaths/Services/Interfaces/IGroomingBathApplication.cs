
using PETiario.PETiary.Application.GroomingBaths.Dtos.Requests;
using PETiario.PETiary.Application.GroomingBaths.Dtos.Responses;

namespace PETiario.PETiary.Application.GroomingBaths.Services.Interfaces
{
    public interface IGroomingBathApplication
    {
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
        Task<GroomingBathResponse> UpdateAsync(int id, GroomingBathRequest groomingBathsRequest, CancellationToken cancellationToken = default);
        Task CreateAsync(GroomingBathRequest groomingBathsRequest, CancellationToken cancellationToken = default);
        Task<IEnumerable<GroomingBathResponse>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<GroomingBathResponse> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        
    }
}