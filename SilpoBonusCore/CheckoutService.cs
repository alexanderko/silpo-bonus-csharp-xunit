namespace SilpoBonusCore
{
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
            if(check.GetTotalCost() >= offer.MinCosts){
                check.AddPoints(offer.Points);
            }
        }
    }
}