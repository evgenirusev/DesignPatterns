namespace AbstractFactoryPattern.Implementation.Products
{
    public class ToteBetInfo : IBetInfo
    {
        public void DisplayBetInfo()
        {
            System.Console.WriteLine("Display -> TOTE Bet Info");
        }
    }
}
