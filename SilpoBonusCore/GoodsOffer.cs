namespace SilpoBonusCore
{
    public class GoodsOffer
    {
        public int MinCosts { get; private set; }
        public int Points { get; private set; }

        public GoodsOffer(int minСosts, int points)
        {
            MinCosts = minСosts;
            Points = points;
        }
    }
}