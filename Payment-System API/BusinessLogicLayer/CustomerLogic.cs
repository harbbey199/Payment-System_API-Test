using Payment_System_API.Controllers;
using Payment_System_API.DataAccessLayer;
using Payment_System_API.DataAccessLayer.Dtos;
using Payment_System_API.Interfaces;

namespace Payment_System_API.BusinessLogicLayer
{
    public class CustomerLogic : ICustomerLogics
    {
        private readonly PaymentContext _dbcontext;

        public CustomerLogic()
        {
        }

        public CustomerLogic(PaymentContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public string AddCustomer(CustomerDto customer)
        {
            try
            {
                if (customer.DateOfBirth < DateTime.Now.AddYears(-18))
                {
                    var newCustomer = new Customer_Details()
                    {
                        CustomerNumber = Guid.NewGuid().ToString(),
                        DateOfBirth = customer.DateOfBirth,
                        Name = customer.Name,
                        Surname = customer.Surname,
                        NationalIdNumber = customer.NationalIdNumber,

                    };
                    _dbcontext.Customers.Add(newCustomer);
                    _dbcontext.SaveChanges();

                    return "customer succesfully added";
                }
                return "Customer not registered";
                

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public List<Customer_Details> GetAllCustomer()
        {
            try
            {
                var customers = _dbcontext.Customers.ToList();
                return customers;
            }
            catch (Exception)
            {

                throw;
            }
       
        }

        public Customer_Details GetCustomerByNationalIdNumber(string customerId)
        {
            try
            {
                var customer = _dbcontext.Customers.Where(x => x.NationalIdNumber == customerId)?.FirstOrDefault();
                return customer;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
