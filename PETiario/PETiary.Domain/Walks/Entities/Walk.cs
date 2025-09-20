


namespace PETiario.PETiary.Domain.Walks.Entities
{
    public class Walk
    {
        public virtual int Id { get; protected set; }
        public virtual int PetId { get; protected set; }
        public virtual DateTime Date { get; protected set; }
        public virtual int DurationMinutes { get; protected set; }
        public virtual string Responsible { get; protected set; }
        public virtual string Note { get; protected set; }

        protected Walk() { }

        public Walk(int petId, DateTime date, int durationMinutes, string note, string responsible)
        {
            SetPetId(petId);
            SetDate(date);
            SetDurationMinutes(durationMinutes);
            SetNote(note);
            SetResponsible(responsible);
        }

        public virtual void SetResponsible(string responsible)
        {
            Responsible = responsible;
        }

        public virtual void SetNote(string note)
        {
            Note = note;
        }

        public virtual void SetDurationMinutes(int durationMinutes)
        {
            DurationMinutes = durationMinutes;
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