namespace SilpoBonusCore
{
    public class FactorByCategoryOffer : GoodsOffer
    {
        public Category FactorCategory { get; private set; }
        public int Factor { get; private set; }

        public FactorByCategoryOffer(Category category, int factor) : base(0, 0)
        {
            FactorCategory = category;
            Factor = factor;
        }
    }
}