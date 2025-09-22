

namespace PETiario.PETiary.Application.Walks.Dtos.Responses
{
    public class WalkResponse
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public DateTime Date { get; set; }
        public int DurationMinutes { get; set; }
        public string Responsible { get; set; }
        public string Note { get; set; }
        
    }
}