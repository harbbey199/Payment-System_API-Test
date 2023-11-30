using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Payment_System_API.DataAccessLayer
{
    public class Merchant_Details
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string? Id { get; set; }
        [Required]  
        public int BusinessId { get; set; }
        [Required]  
        public string? BusinessName { get; set; }
        [Required]  
        public string? ContactName { get; set; }
        [Required]  
        public string? ContactSurname { get; set; }
        [Required]  
        public DateTime DateOfEstablishment { get; set; }
        public string? MerchantNumber { get; set; }
        public decimal? AverageTransactionVolume { get; set; }
    }
}
