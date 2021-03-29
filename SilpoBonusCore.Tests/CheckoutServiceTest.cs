using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class CheckoutServiceTest
    {
        [Fact]
        void CloseCheck_WithOneProduct(){
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product("Butter", 17));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 17);
        }

        [Fact]
        void CloseCheck_WithTwoProduct(){
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product("Butter", 17));
            checkoutService.AddProduct(new Product("Egg", 3));

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 20);
        }
    }
}
