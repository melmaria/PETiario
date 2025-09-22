
using PETiario.PETiary.Application.Vaccinations.Dtos.Requests;
using PETiario.PETiary.Application.Vaccinations.Dtos.Responses;

namespace PETiario.PETiary.Application.Vaccinations.Services.Interfaces
{
    public interface IVaccinationApplication
    {
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
        Task<VaccinationResponse> UpdateAsync(int id, VaccionationRequest vaccionationsRequest, CancellationToken cancellationToken = default);
        Task CreateAsync(VaccionationRequest vaccionationsRequest, CancellationToken cancellationToken = default);
        Task<IEnumerable<VaccinationResponse>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<VaccinationResponse> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}