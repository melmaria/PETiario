
using PETiario.PETiary.Application.Appointements.Dtos.Requests;
using PETiario.PETiary.Application.Appointements.Dtos.Responses;

namespace PETiario.PETiary.Application.Appointements.Services.Interfaces
{
    public interface IAppointmentApplication
    {
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
        Task<AppointmentResponse> UpdateAsync(int id, AppointmentRequest appointmentsRequest, CancellationToken cancellationToken = default);
        Task CreateAsync(AppointmentRequest appointmentsRequest, CancellationToken cancellationToken = default);
        Task<IEnumerable<AppointmentResponse>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<AppointmentResponse> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}