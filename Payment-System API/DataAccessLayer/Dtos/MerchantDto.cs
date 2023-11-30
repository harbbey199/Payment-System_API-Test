using System.ComponentModel.DataAnnotations;

namespace Payment_System_API.DataAccessLayer.Dtos
{
    public class MerchantDto
    {
        public int BusinessId { get; set; }
        public string? BusinessName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactSurname { get; set; }
        public DateTime DateOfEstablishment { get; set; }
        
        
    }
}
