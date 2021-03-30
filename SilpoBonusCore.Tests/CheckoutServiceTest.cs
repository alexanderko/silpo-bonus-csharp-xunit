<<<<<<< HEAD
using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class CheckoutServiceTest
    {
        CheckoutService checkoutService;

        private Product milk_14;
        private Product butter_17;
        private Product egg_3;

        public CheckoutServiceTest(){
            checkoutService = new CheckoutService();

            milk_14 = new Product("Milk", 14);
            butter_17 = new Product("Butter", 17, Category.Butter);
            egg_3 = new Product("Egg", 3, Category.Egg);
        }

        [Fact]
        void CloseCheck__WithOneProduct(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 17);
        }

        [Fact]
        void CloseCheck__WithTwoProduct(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 20);
        }

        [Fact]
        void AddProduct__InCloseCheck(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            Check check = checkoutService.CloseCheck();

            //checkoutService.AddProduct(egg);

            Assert.Equal(check.GetTotalCost(), 20);
        }

        [Fact]
        void CloseCheck__CheckPoints(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.TotalPoints, 40);
        }

        [Fact]
        void CloseCheck__AddOfferPoints(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            checkoutService.UseOffer(new GoodsOffer(8, 4));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.TotalPoints, 44);
        }

        [Fact]
        void CloseCheck__whenCostLessThanRequired__DontAddPoint(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            checkoutService.UseOffer(new GoodsOffer(40, 4));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.TotalPoints, 40);
        }

        [Fact]
        void CloseCheck__UseFactorByCategory(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            checkoutService.UseOffer(new FactorByCategoryOffer(Category.Butter, 2));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.TotalPoints, 71);
        }
    }
}
=======
using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class CheckoutServiceTest
    {
        CheckoutService checkoutService;

        private Product milk_14;
        private Product butter_17;
        private Product egg_3;

        public CheckoutServiceTest(){
            checkoutService = new CheckoutService();

            milk_14 = new Product("Milk", 14);
            butter_17 = new Product("Butter", 17, Category.Butter);
            egg_3 = new Product("Egg", 3, Category.Egg);
        }

        [Fact]
        void CloseCheck__WithOneProduct(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 17);
        }

        [Fact]
        void CloseCheck__WithTwoProduct(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 20);
        }

        [Fact]
        void AddProduct__InCloseCheck(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            Check check = checkoutService.CloseCheck();

            //checkoutService.AddProduct(egg);

            Assert.Equal(check.GetTotalCost(), 20);
        }

        [Fact]
        void CloseCheck__CheckPoints(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 20);
        }

        [Fact]
        void CloseCheck__AddOfferPoints(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            checkoutService.UseOffer(new GoodsOffer(8, 4));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 24);
        }

        [Fact]
        void CloseCheck__whenCostLessThanRequired__DontAddPoint(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            checkoutService.UseOffer(new GoodsOffer(40, 4));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 20);
        }

        [Fact]
        void CloseCheck__UseFactorByCategory(){
            checkoutService.OpenCheck();

            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(butter_17);
            checkoutService.AddProduct(egg_3);

            checkoutService.UseOffer(new FactorByCategoryOffer(Category.Butter, 3));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 105);
        }
    }
}
>>>>>>> Add new offers and move UseOffers logic to abstract class
