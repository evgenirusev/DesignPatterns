using Implementation.AbstractFactories;
using Implementation.AbstractProducts;

namespace Implementation
{
    public class BetsState
    {
        private readonly IBetsAbstractFactory _betAbstractFactory;

        public BetsState(IBetsAbstractFactory betAbstractFactory)
        {
            _betAbstractFactory = betAbstractFactory;
        }

        public void BetPropsBuilder()
        {
            IFootballBet footballBet = _betAbstractFactory.CreateFootballBet();
            IBasketballBet basketballBet = _betAbstractFactory.CreateBasketballBet();

            footballBet.DisplayFootballBet();
            basketballBet.DisplayBasketballBet();
        }
    }
}
