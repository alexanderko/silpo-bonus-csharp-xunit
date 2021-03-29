namespace SilpoBonusCore
{
    public class Product
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public Category ProductCategory { get; private set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name, int price, Category category) : this(name, price)
        {
            ProductCategory = category;
        }
    }
}