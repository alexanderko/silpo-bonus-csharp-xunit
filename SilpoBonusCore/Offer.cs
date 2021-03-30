namespace SilpoBonusCore{
    public abstract class Offer
    {
        public Offer(){}

        internal abstract void Apply(Check check);
    }
}