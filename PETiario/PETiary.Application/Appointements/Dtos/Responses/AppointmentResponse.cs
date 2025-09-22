
namespace PETiario.PETiary.Application.Appointements.Dtos.Responses
{
    public class AppointmentResponse
    {
        public int Id { get; set; }
        public int PetName { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Vet { get; set; }
        public string Note { get; set; }
        public bool Attend { get; set; }
    }
}