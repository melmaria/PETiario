

namespace PETiario.PETiary.Domain.Vaccinations.Entities
{
    public class Vaccination
    {
        public virtual int Id { get; protected set; }
        public virtual int PetId { get; protected set; }
        public virtual string Vaccinate { get; protected set; }
        public virtual DateTime ShotDate { get; protected set; }
        public virtual DateTime? NextShot { get; protected set; }
        public virtual bool Applied { get; protected set; } = false;
        public virtual string Note { get; protected set; }

        protected Vaccination() { }

        public Vaccination(int petId, string vaccinate, DateTime shotDate, string note, DateTime? nextShot, bool applied = false)
        {
            SetPetId(petId);
            SetVaccinate(vaccinate);
            SetShotDate(shotDate);
            SetNextShot(nextShot);
            SetApplied(applied);
            SetNote(note);  
            
        }

        public virtual void SetNote(string note)
        {
            Note = note;
        }

        public virtual void SetApplied(bool applied)
        {
            Applied = applied;
        }

        public virtual void SetNextShot(DateTime? nextShot)
        {
            NextShot = nextShot;
        }

        public virtual void SetShotDate(DateTime shotDate)
        {
            ShotDate = shotDate;
        }

        public virtual void SetVaccinate(string vaccinate)
        {
            Vaccinate = vaccinate;
        }

        public virtual void SetPetId(int petId)
        {
            PetId = petId;
        }
    }
}