
using PETiario.PETiary.Application.Appointements.Dtos.Requests;
using PETiario.PETiary.Application.Appointements.Dtos.Responses;

namespace PETiario.PETiary.Application.Appointements.Services.Interfaces
{
    public interface IAppointmentApplication
    {
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
        Task<AppointmentsResponse> UpdateAsync(int id, AppointmentsRequest appointmentsRequest, CancellationToken cancellationToken = default);
        Task CreateAsync(AppointmentsRequest appointmentsRequest, CancellationToken cancellationToken = default);
        Task<IEnumerable<AppointmentsResponse>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<AppointmentsResponse> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}