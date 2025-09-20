
using PETiario.PETiary.Domain.GroomingBaths.Enumerators;

namespace PETiario.PETiary.Domain.GroomingBaths.Entities
{
    public class GroomingBath
    {
        public virtual int Id { get; protected set; }
        public virtual int PetId { get; protected set; }
        public virtual DateTime Date { get; protected set; }
        public virtual KindEnum Kind { get; protected set; }
        public virtual string Location { get; protected set; }
        public virtual string Note { get; protected set; }

        protected GroomingBath() { }

        public GroomingBath(int petId, DateTime date, KindEnum kind, string location, string note)
        {
            SetPetId(petId);
            SetDate(date);
            SetKind(kind);
            SetLocation(location);
            SetNote(note);
        }

        public virtual void SetNote(string note)
        {
            Note = note;
        }

        public virtual void SetLocation(string location)
        {
            Location = location;
        }

        public virtual void SetKind(KindEnum kind)
        {
            Kind = kind;
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