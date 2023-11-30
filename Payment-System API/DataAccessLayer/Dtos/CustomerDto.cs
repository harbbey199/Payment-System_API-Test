using System.ComponentModel.DataAnnotations;

namespace Payment_System_API.DataAccessLayer.Dtos
{
    public class CustomerDto
    {
        public string? NationalIdNumber { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? CustomerNumber { get; set; }
    }
}
