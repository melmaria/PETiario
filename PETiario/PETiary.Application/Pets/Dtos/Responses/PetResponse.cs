
namespace PETiario.PETiary.Application.Pets.Dtos.Responses
{
    public class PetResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public double? Age { get; set; }
        public string Gender { get; set; }
        public string Picture { get; set; }
        public int Owner { get; set; }
        
    }
}