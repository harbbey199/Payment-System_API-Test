using Payment_System_API.DataAccessLayer;
using Payment_System_API.DataAccessLayer.Dtos;

namespace Payment_System_API.Interfaces
{
    public interface ICustomerLogics
    {

        List<Customer_Details> GetAllCustomer();
        Customer_Details GetCustomerByNationalIdNumber(string customerId);  
        string AddCustomer(CustomerDto customer);    
    }
}
