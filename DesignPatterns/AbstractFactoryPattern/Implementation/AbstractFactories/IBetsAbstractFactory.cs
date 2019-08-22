using AbstractFactoryPattern.Implementation.Products;

namespace AbstractFactoryPattern.Implementation.AbstractFactories
{
    public interface IBetsAbstractFactory
    {
        IBetInfo CreateBetInfo();
        IPlaceBetsButton CreatePlaceBetsButton();
    }
}
