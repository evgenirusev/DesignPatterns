namespace AbstractFactory.AbstractFactories
{
    public class ToteBetsAbstractFactory : IBetsAbstractFactory
    {
        public IBetInfo CreateBetInfo()
        {
            return new ToteBetInfo();
        }

        public IPlaceBetsButton CreatePlaceBetsButton()
        {
            return new TotePlaceBetsButton();
        }
    }
}
