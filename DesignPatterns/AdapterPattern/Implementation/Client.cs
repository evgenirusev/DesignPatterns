using AdapterPattern.Implementation.Adaptee;
using AdapterPattern.Implementation.Adapter;
using AdapterPattern.Implementation.Target;

namespace AdapterPattern.Implementation
{
    public class Client
    {
        public static void Main(string[] args)
        {
            // the client needs INotificationSender target interface.

            INotificationSender notificationSender = new LegacyNotifierAdapter(new LegacyNotifier());

            notificationSender.SendNotification();
        }
    }
}
