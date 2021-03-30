namespace SilpoBonusCore
{
    public enum Category
    {
        Milk = 14,
        Butter = 17,
        Egg = 3
    }

    public class CheckoutService
    {
        private Check check;
        public void OpenCheck(){
            check = new Check();
        }

        public void AddProduct(Product product){
<<<<<<< HEAD
            check.AddProduct(product);
            check.AddPoints(product.Price * 2);
=======
            if(check == null){
                check = new Check();
            }

            check.AddProduct(product);
>>>>>>> Add new offers and move UseOffers logic to abstract class
        }

        public Check CloseCheck(){
            Check temp = check;
            check = null;

            return temp;
        }

<<<<<<< HEAD
        public void UseOffer(GoodsOffer offer){
            FactorByCategoryOffer fb = offer as FactorByCategoryOffer;

            if(fb != null){
                int points = check.GetTotalCostByCategory(fb.FactorCategory);
                check.
            }
            else{
                if(check.GetTotalCost() >= offer.MinCosts){
                    check.AddPoints(offer.Points);
                }
            }
=======
        public void UseOffer(Offer offer){
            offer.Apply(check);
>>>>>>> Add new offers and move UseOffers logic to abstract class
        }
    }
}