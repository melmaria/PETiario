
using Microsoft.EntityFrameworkCore;
using PETiario.PETiary.Domain.Appointments.Entities;
using PETiario.PETiary.Domain.GroomingBaths.Entities;
using PETiario.PETiary.Domain.Owners.Entities;
using PETiario.PETiary.Domain.Pets.Entities;
using PETiario.PETiary.Domain.Vaccinations.Entities;
using PETiario.PETiary.Domain.Walks.Entities;

namespace PETiario.PETiary.Infra.Persistence.Repositories
{
    public class PetiaryDbContext(DbContextOptions<PetiaryDbContext> options) : DbContext(options)
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<GroomingBath> GroomingBaths { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Walk> Walks{ get; set; }
    }
}