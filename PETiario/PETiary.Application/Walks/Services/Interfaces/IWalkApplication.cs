
using PETiario.PETiary.Application.Walks.Dtos.Requests;
using PETiario.PETiary.Application.Walks.Dtos.Responses;

namespace PETiario.PETiary.Application.Walks.Services.Interfaces
{
    public interface IWalkApplication
    {
       Task DeleteAsync(int id, CancellationToken cancellationToken = default);
        Task<WalkResponse> UpdateAsync(int id, WalkRequest walksRequest, CancellationToken cancellationToken = default);
        Task CreateAsync(WalkRequest walksRequest, CancellationToken cancellationToken = default);
        Task<IEnumerable<WalkResponse>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<WalkResponse> GetByIdAsync(int id, CancellationToken cancellationToken = default); 
    }
}