
namespace PETiario.PETiary.Application.Appointements.Dtos.Requests
{
    public class AppointmentsRequest
    {
        public int PetId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Vet { get; set; }
        public string Note { get; set; }
        public bool Attend { get; set; } 
        
    }
}