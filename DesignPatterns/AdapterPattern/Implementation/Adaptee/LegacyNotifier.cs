namespace AdapterPattern.Implementation.Adaptee
{
    public class LegacyNotifier
    {
        public void NotifyUsingHttp()
        {
            System.Console.WriteLine("Sending notification...");
        }

        public void NotifyUsingNetwork()
        {
            System.Console.WriteLine("Sending network notification...");
        }
    }
}
