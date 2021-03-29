using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class CheckoutServiceTest
    {
        CheckoutService checkoutService;

        private Product milk;
        private Product butter;
        private Product egg;

        public CheckoutServiceTest(){
            checkoutService = new CheckoutService();

            milk = new Product("Milk", 14);
            butter = new Product("Butter", 17);
            egg = new Product("Egg", 3);
        }

        [Fact]
        void CloseCheck__WithOneProduct(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter);
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 17);
        }

        [Fact]
        void CloseCheck__WithTwoProduct(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter);
            checkoutService.AddProduct(egg);

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 20);
        }

        [Fact]
        void CloseCheck__InCloseCheck(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter);
            checkoutService.AddProduct(egg);

            Check check = checkoutService.CloseCheck();

            checkoutService.AddProduct(egg);

            Assert.Equal(check.GetTotalCost(), 20);
        }

        [Fact]
        void CloseCheck__CheckPoints(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter);
            checkoutService.AddProduct(egg);

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.TotalPoints, 40);
        }

        [Fact]
        void CloseCheck__AddOfferPoints(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter);
            checkoutService.AddProduct(egg);

            checkoutService.UseOffer(new GoodsOffer(8, 4));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.TotalPoints, 44);
        }

        [Fact]
        void CloseCheck__whenCostLessThanRequired__DontAddPoint(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter);
            checkoutService.AddProduct(egg);

            checkoutService.UseOffer(new GoodsOffer(40, 4));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.TotalPoints, 40);
        }
    }
}
