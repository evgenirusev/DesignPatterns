using Implementation.AbstractProducts;

namespace Implementation.AbstractFactories
{
    public interface IBetsAbstractFactory
    {
        IFootballBet CreateFootballBet();
        IBasketballBet CreateBasketballBet();
    }
}
