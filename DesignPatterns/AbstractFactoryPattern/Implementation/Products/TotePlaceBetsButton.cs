namespace AbstractFactoryPattern.Implementation.Products
{
    public class TotePlaceBetsButton : IPlaceBetsButton
    {
        public void DisplayPlaceBetsButton()
        {
            System.Console.WriteLine("Display -> TOTE PlaceBets Button");
        }
    }
}
