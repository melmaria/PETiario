
namespace PETiario.PETiary.Domain.Appointments.Entities
{
    public class Appointment
    {
        public virtual int Id { get; protected set; }
        public virtual int PetId { get; protected set; }
        public virtual DateTime Date { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual string Vet { get; protected set; }
        public virtual string Note { get; protected set; }
        public virtual bool Attend { get; protected set; } = false;

        protected Appointment() { }

        public Appointment(
            int petId, DateTime date, string description, string vet, string note, bool attend = false)
        {
            SetPetId(petId);
            SetDate(date);
            SetDescription(description);
            SetVet(vet);
            SetNote(note);
            SetAttend(attend);
        }

        public virtual void SetAttend(bool attend)
        {
            Attend = attend;
        }

        public virtual void SetNote(string note)
        {
            Note = note;
        }

        public virtual void SetVet(string vet)
        {
            Vet = vet;
        }

        public virtual void SetDescription(string description)
        {
            Description = description;
        }

        public virtual void SetDate(DateTime date)
        {
            Date = date;
        }

        public virtual void SetPetId(int petId)
        {
            PetId = petId;
        }

    }
}