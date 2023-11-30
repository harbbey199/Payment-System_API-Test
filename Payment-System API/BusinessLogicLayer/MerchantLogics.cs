using Payment_System_API.Controllers;
using Payment_System_API.DataAccessLayer;
using Payment_System_API.DataAccessLayer.Dtos;
using Payment_System_API.Interfaces;

namespace Payment_System_API.BusinessLogicLayer
{
    public class MerchantLogics : IMerchantLogics
    {
        private readonly PaymentContext _dbcontext;

        public MerchantLogics(PaymentContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public string AddMerchant(MerchantDto merchant)
        {
            try
            {
                if (merchant.DateOfEstablishment < DateTime.Now.AddYears(-1))
                {
                    var newmerchant = new Merchant_Details()
                    {
                        MerchantNumber = Guid.NewGuid().ToString(),
                        DateOfEstablishment = merchant.DateOfEstablishment,
                        BusinessName = merchant.BusinessName,
                        ContactName = merchant.ContactName,
                        ContactSurname = merchant.ContactSurname,
                        BusinessId = merchant.BusinessId,

                    };
                    _dbcontext.Merchants.Add(newmerchant);
                    _dbcontext.SaveChanges();

                    return "Merchant successfully Added";
                }
                return "Merchant not registered";
               

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public List<Merchant_Details> GetAllMerchant()
        {
            try
            {
                var merchants = _dbcontext.Merchants.ToList();
                return merchants;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Merchant_Details GetMerchantbyBusinessName(string name)
        {
            try
            {
                var merchant = _dbcontext.Merchants.Where(x => x.BusinessName == name).FirstOrDefault();
                return merchant;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
