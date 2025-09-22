
using PETiario.PETiary.Application.Owners.Dtos.Requests;
using PETiario.PETiary.Application.Owners.Dtos.Responses;

namespace PETiario.PETiary.Application.Owners.Services.Interfaces
{
    public interface IOwnerApplication
    {
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
        Task<OwnerResponse> UpdateAsync(int id, OwnerRequest ownersRequest, CancellationToken cancellationToken = default);
        Task CreateAsync(OwnerRequest ownersRequest, CancellationToken cancellationToken = default);
        Task<IEnumerable<OwnerResponse>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<OwnerResponse> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}