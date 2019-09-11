using Implementation.AbstractProducts;
using Implementation.ConcreteProducts;

namespace Implementation.AbstractFactories
{
    public class ToteBetsAbstractFactory : IBetsAbstractFactory
    {
        public IFootballBet CreateFootballBet()
        {
            return new ToteFootballBet();
        }

        public IBasketballBet CreateBasketballBet()
        {
            return new ToteBasketballBet();
        }
    }
}
