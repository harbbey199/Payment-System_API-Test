using Payment_System_API.BusinessLogicLayer;
using Payment_System_API.DataAccessLayer;
using Payment_System_API.DataAccessLayer.Dtos;

namespace PaymentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            MerchantLogics merchant = new MerchantLogics(); 
            MerchantDto newmerchant = new MerchantDto()
            {
                BusinessId = 1,
                BusinessName = "Test",
                ContactSurname = "Test1",
                ContactName = "Test2",
                DateOfEstablishment = DateTime.Now.AddYears(-3),
            };    

            //act
            merchant.AddMerchant(newmerchant);

            //assert
            Merchant_Details retrievedMerchant = merchant.GetMerchantbyBusinessName("Test");
            Assert.AreEqual(newmerchant, retrievedMerchant);

        }
        [TestMethod]
        public void TestMethod2() 
        {
            //arrange
            CustomerLogic customer = new CustomerLogic();
            CustomerDto customer2 = new CustomerDto()
            {
                CustomerNumber = "12",
                Surname = "Test",
                DateOfBirth = DateTime.Now.AddYears(-22),
                Name = "Test",
                NationalIdNumber = "252566"
            };
            //act
            customer.AddCustomer(customer2);
            //assert
            Customer_Details customer_Details = customer.GetCustomerByNationalIdNumber("252566");
            Assert.AreEqual(customer, customer_Details);
        }
    }
}