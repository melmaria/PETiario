
namespace PETiario.PETiary.Application.Vaccinations.Dtos.Requests
{
    public class VaccionationRequest
    {
        public int PetId { get; set; }
        public string Vaccinate { get; set; }
        public DateTime ShotDate { get; set; }
        public DateTime? NextShot { get; set; }
        public bool Applied { get; set; } = false;
        public string Note { get; set; }
        
    }
}