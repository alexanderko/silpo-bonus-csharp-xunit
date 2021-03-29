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
            check.AddProduct(product);
            check.AddPoints(product.Price * 2);
        }

        public Check CloseCheck(){
            Check temp = check;
            check = null;

            return temp;
        }

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
        }
    }
}