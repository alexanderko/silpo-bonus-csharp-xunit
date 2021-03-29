using System.Collections.Generic;

namespace SilpoBonusCore
{
    public class Check
    {
        private List<Product> products;
        public int TotalPoints { get; private set; }

        public Check()
        {
            products = new List<Product>();
        }

        public int GetTotalCost(){
            int totalCost = 0;

            foreach (Product product in products)
            {
                totalCost += product.Price;
            }

            return totalCost;
        }

        public int GetTotalCostByCategory(Category category){
            int totalCost = 0;
            
            foreach (Product product in products)
            {
                if(product.ProductCategory == Category.Butter){
                    totalCost += product.Price * 2;
                    System.Console.WriteLine(product.Price * 2);
                }
                else{
                    totalCost += product.Price;
                    System.Console.WriteLine(product.Price);
                }
            }

            return totalCost;
        }

        internal void AddProduct(Product product){
            products.Add(product);
        }

        internal void AddPoints(int points){
            TotalPoints += points;
        }
    }
}