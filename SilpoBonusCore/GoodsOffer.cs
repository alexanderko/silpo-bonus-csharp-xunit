namespace SilpoBonusCore
{
<<<<<<< HEAD
    public class GoodsOffer
=======
    public class GoodsOffer : Offer
>>>>>>> Add new offers and move UseOffers logic to abstract class
    {
        public int MinCosts { get; private set; }
        public int Points { get; private set; }

        public GoodsOffer(int minСosts, int points)
        {
            MinCosts = minСosts;
            Points = points;
        }
<<<<<<< HEAD
=======

        internal override void Apply(Check check){
            if(check.GetTotalCost() >= MinCosts){
                check.AddPoints(Points);
            }
        }
>>>>>>> Add new offers and move UseOffers logic to abstract class
    }
}