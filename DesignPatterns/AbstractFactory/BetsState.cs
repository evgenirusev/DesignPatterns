namespace AbstractFactory
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
            IBetInfo betInfo = _betAbstractFactory.CreateBetInfo();
            IPlaceBetsButton placeBetsButton = _betAbstractFactory.CreatePlaceBetsButton();

            // Use the products which are created from the abstract factory
            betInfo.DisplayBetInfo();
            placeBetsButton.DisplayPlaceBetsButton();
        }
    }
}
