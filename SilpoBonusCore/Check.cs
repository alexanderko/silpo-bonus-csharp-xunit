using System.Collections.Generic;

namespace SilpoBonusCore
{
    public class Check
    {
        private List<Product> products = new List<Product>();

        public int GetTotalCost(){
            int totalCost = 0;

            foreach (Product product in products)
            {
                totalCost += product.Price;
            }

            return totalCost;
        }

        public void AddProduct(Product product){
            products.Add(product);
        }
    }
}