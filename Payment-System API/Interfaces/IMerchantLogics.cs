using Payment_System_API.DataAccessLayer;
using Payment_System_API.DataAccessLayer.Dtos;

namespace Payment_System_API.Interfaces
{
    public interface IMerchantLogics
    {
        List<Merchant_Details> GetAllMerchant();
        Merchant_Details GetMerchantbyBusinessName(string name);
        string AddMerchant(MerchantDto merchant);
    }
}
