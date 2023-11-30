using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Payment_System_API.DataAccessLayer
{
    public class Customer_Details
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string? Id { get; set; }
        [Required]
        public string? NationalIdNumber { get; set; }
        [Required]  
        public string? Name { get; set; }
        [Required]  
        public string? Surname { get; set; }
        [Required]  
        public DateTime DateOfBirth { get; set; }
        [Required]  
        public string? CustomerNumber { get; set; }
        public ICollection<TransactionHistories>? TransactionHistory { get; set; }
    }
}
