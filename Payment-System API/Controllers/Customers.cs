using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment_System_API.DataAccessLayer.Dtos;
using Payment_System_API.Interfaces;

namespace Payment_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customers : ControllerBase
    {
        
        private readonly ICustomerLogics _customer;

        public Customers( ICustomerLogics customer)
        {
            
            _customer = customer;
        }

        [HttpGet("GetAllCustomer")]   
        public async Task<IActionResult> GetAllCustomer() 
        {
            var customers = _customer.GetAllCustomer();  
            return Ok(customers);
        }
        [HttpGet("GetCustomerbyId")]   
        public async Task<IActionResult>GetCustomerbyId(string Id)
        {
            var customer = _customer.GetCustomerByNationalIdNumber(Id);
            return Ok(customer);
        }
        [HttpPost("AddCustomer")]
        public async Task<IActionResult>AddCustomer(CustomerDto customer)
        {
            if (customer != null)
            {
               var result = _customer.AddCustomer(customer);
                if (result == "customer succesfully added")
                {
                    return Ok("Customer registered");
                }
                return BadRequest("Customer not registered");    
            }
            return BadRequest();    
        }
    }
}
