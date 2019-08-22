using Implementation.Products;

namespace Implementation.AbstractFactories
{
    public interface IBetsAbstractFactory
    {
        IBetInfo CreateBetInfo();
        IPlaceBetsButton CreatePlaceBetsButton();
    }
}
