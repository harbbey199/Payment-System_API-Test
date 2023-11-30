using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment_System_API.DataAccessLayer.Dtos;
using Payment_System_API.Interfaces;

namespace Payment_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Merchants : ControllerBase
    {
        private readonly IMerchantLogics _merchant;

        public Merchants(IMerchantLogics merchant)
        {
            _merchant = merchant;
        }

        [HttpGet("GetAllMerchants")]
        public async Task<IActionResult> getAllMerchants()
        {
            var merchants = _merchant.GetAllMerchant();
            return Ok(merchants);
        }
        [HttpGet("GetMerchantbyname")]
        public async Task<IActionResult> GetMerchantByName(string name)
        {
            var merchant = _merchant.GetMerchantbyBusinessName(name);
            return Ok(merchant);
        }

        [HttpPost("AddMerchant")]
        public async Task<IActionResult>AddMerchant(MerchantDto merchant)
        {
            if(merchant != null) 
            {
                var result =_merchant.AddMerchant(merchant);
                if(result == "Merchant successfully Added")
                {
                    return Ok("Merchant Successfully registered");
                }
                
            }
            return BadRequest("Merchant not registered");

        }
    }
}
