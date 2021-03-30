namespace SilpoBonusCore
{
<<<<<<< HEAD
    public class FactorByCategoryOffer : GoodsOffer
=======
    public class FactorByCategoryOffer : Offer
>>>>>>> Add new offers and move UseOffers logic to abstract class
    {
        public Category FactorCategory { get; private set; }
        public int Factor { get; private set; }

<<<<<<< HEAD
        public FactorByCategoryOffer(Category category, int factor) : base(0, 0)
=======
        public FactorByCategoryOffer(Category category, int factor)
>>>>>>> Add new offers and move UseOffers logic to abstract class
        {
            FactorCategory = category;
            Factor = factor;
        }
<<<<<<< HEAD
=======

        internal override void Apply(Check check){
            int points = check.GetTotalCostByCategory(FactorCategory);
            check.AddPoints(points * (Factor - 1));
        }
>>>>>>> Add new offers and move UseOffers logic to abstract class
    }
}