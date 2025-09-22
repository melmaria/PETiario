
namespace PETiario.PETiary.Application.Walks.Dtos.Requests
{
    public class WalkRequest
    {
        public int PetId { get; set; }
        public DateTime Date { get; set; }
        public int DurationMinutes { get; set; }
        public string Responsible { get; set; }
        public string Note { get; set; }
        
    }
}