namespace AbstractFactory.AbstractFactories
{
    public class MansionBetsAbstractFactory : IBetsAbstractFactory
    {
        public IBetInfo CreateBetInfo()
        {
            return new MansionBetInfo();
        }

        public IPlaceBetsButton CreatePlaceBetsButton()
        {
            return new MansionPlaceBetsButton();
        }
    }
}
