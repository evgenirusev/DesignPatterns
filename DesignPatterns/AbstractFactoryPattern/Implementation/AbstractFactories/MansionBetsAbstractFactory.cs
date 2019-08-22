using AbstractFactoryPattern.Implementation.Products;

namespace AbstractFactoryPattern.Implementation.AbstractFactories
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
