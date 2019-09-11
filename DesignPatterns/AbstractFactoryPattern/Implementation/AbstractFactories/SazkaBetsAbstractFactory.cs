using Implementation.AbstractProducts;
using Implementation.ConcreteProducts;

namespace Implementation.AbstractFactories
{
    public class SazkaBetsAbstractFactory : IBetsAbstractFactory
    {
        public IBasketballBet CreateBasketballBet()
        {
            return new SazkaBasketballBet();
        }

        public IFootballBet CreateFootballBet()
        {
            return new SazkaFootballBet();
        }
    }
}
