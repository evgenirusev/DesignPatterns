using AbstractFactoryPattern.Implementation.Products;

namespace AbstractFactoryPattern.Implementation.AbstractFactories
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
