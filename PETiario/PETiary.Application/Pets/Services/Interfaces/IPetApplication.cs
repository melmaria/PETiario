
using PETiario.PETiary.Application.Pets.Dtos.Requests;
using PETiario.PETiary.Application.Pets.Dtos.Responses;

namespace PETiario.PETiary.Application.Pets.Services.Interfaces
{
    public interface IPetApplication
    {
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
        Task<PetResponse> UpdateAsync(int id, PetRequest petsRequest, CancellationToken cancellationToken = default);
        Task CreateAsync(PetRequest petsRequest, CancellationToken cancellationToken = default);
        Task<IEnumerable<PetResponse>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<PetResponse> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}