using System.Collections.Generic;

namespace SilpoBonusCore
{
    public class Check
    {
        private List<Product> products;
<<<<<<< HEAD
        public int TotalPoints { get; private set; }
=======
        private int points = 0;
>>>>>>> Add new offers and move UseOffers logic to abstract class

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

<<<<<<< HEAD
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
=======
        public int GetTotalPoints(){
            return GetTotalCost() + points;
        }

        public int GetTotalCostByCategory(Category category){
            int totalPoints = 0;
            
            foreach (Product product in products)
            {
                if(product.ProductCategory == category){
                    totalPoints += product.Price;
                }
            }

            return totalPoints;
>>>>>>> Add new offers and move UseOffers logic to abstract class
        }

        internal void AddProduct(Product product){
            products.Add(product);
        }

<<<<<<< HEAD
        internal void AddPoints(int points){
            TotalPoints += points;
=======
        internal void AddPoints(int p){
            points += p;
>>>>>>> Add new offers and move UseOffers logic to abstract class
        }
    }
}