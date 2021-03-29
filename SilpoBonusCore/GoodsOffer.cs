namespace SilpoBonusCore
{
    public class GoodsOffer
    {
        public int MinCosts { get; set; }
        public int Points { get; set; }

        public GoodsOffer(int minСosts, int points)
        {
            MinCosts = minСosts;
            Points = points;
        }
    }
}