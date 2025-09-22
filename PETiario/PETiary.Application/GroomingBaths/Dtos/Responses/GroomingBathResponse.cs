
namespace PETiario.PETiary.Application.GroomingBaths.Dtos.Responses
{
    public class GroomingBathResponse
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public DateTime Date { get; set; }
        public string Kind { get; set; }
        public string Location { get; set; }
        public string Note { get; set; }
        
    }
}