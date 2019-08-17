namespace AbstractFactory
{
    public interface IBetsAbstractFactory
    {
        IBetInfo CreateBetInfo();
        IPlaceBetsButton CreatePlaceBetsButton();
    }
}
