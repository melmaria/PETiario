using AutoMapper;
using EFCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using PETiario.PETiary.Application.Appointements.Dtos.Requests;
using PETiario.PETiary.Application.Appointements.Dtos.Responses;
using PETiario.PETiary.Application.Appointements.Services.Interfaces;
using PETiario.PETiary.Domain.Appointments.Entities;

namespace PETiario.PETiary.Application.Appointements.Services
{
    public class AppointmentApplication(
        IUnitOfWork unitOfWork,
        ILogger<AppointmentApplication> logger,
        IMapper mapper) : IAppointmentApplication
    {
        public async Task CreateAsync(AppointmentsRequest appointmentsRequest, CancellationToken cancellationToken = default)
        {
            try
            {
                var repository = unitOfWork.GetRepository<Appointment>();

                Appointment appointment = mapper.Map<Appointment>(appointmentsRequest);

                await repository.InsertAsync(appointment, cancellationToken);
                await unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could not create a new appointment.");
                throw;
            }
        }

        public async Task<AppointmentsResponse> UpdateAsync(int id, AppointmentsRequest appointmentsRequest, CancellationToken cancellationToken = default)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentNullException("Invalid id.", nameof(id));

                var repository = unitOfWork.GetRepository<Appointment>();
                var existing = await repository.FindAsync(id, cancellationToken)
                    ?? throw new KeyNotFoundException("Appointment not found.");
                    
                mapper.Map(appointmentsRequest, existing);
                repository.Update(existing);
                await unitOfWork.SaveChangesAsync();
                return mapper.Map<AppointmentsResponse>(existing);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could not update the existing appointment.");
                throw;
            }
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentNullException("Invalid id.", nameof(id)); 

                var repository = unitOfWork.GetRepository<Appointment>();   
                var existing = await repository.FindAsync(id, cancellationToken) 
                    ?? throw new KeyNotFoundException("Appointment not found.");
                repository.Delete(existing);
                await unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could not delete the existing appointment.");
                throw;
            }
        }

        public async Task<IEnumerable<AppointmentsResponse>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var repository = unitOfWork.GetRepository<Appointment>();
            var appointments = await repository.GetAll()
                .ToListAsync(cancellationToken);
            return mapper.Map<IEnumerable<AppointmentsResponse>>(appointments);
        }

        public async Task<AppointmentsResponse> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            if (id <= 0)
                throw new ArgumentNullException("Invalid id.", nameof(id));   

            var repository = unitOfWork.GetRepository<Appointment>();
            var appointment = await repository.FindAsync(id, cancellationToken) 
                ?? throw new KeyNotFoundException("Appointment not found.");
            return mapper.Map<AppointmentsResponse>(appointment);
            
        }
    }
}