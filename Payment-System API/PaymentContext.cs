using Microsoft.EntityFrameworkCore;
using Payment_System_API.DataAccessLayer;

namespace Payment_System_API
{
    public class PaymentContext:DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext>options):base(options) { }

        public DbSet<Merchant_Details> Merchants{ get; set;}
        public DbSet<Customer_Details> Customers { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Merchant_Details>().HasIndex(x => x.MerchantNumber).IsUnique();
        }
    }
}
