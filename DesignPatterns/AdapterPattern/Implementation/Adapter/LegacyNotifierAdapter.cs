using AdapterPattern.Implementation.Adaptee;
using AdapterPattern.Implementation.Target;

namespace AdapterPattern.Implementation.Adapter
{
    public class LegacyNotifierAdapter : INotificationSender
    {
        private readonly LegacyNotifier _legacyNotifier;

        public LegacyNotifierAdapter(LegacyNotifier legacyNotifier)
        {
            _legacyNotifier = legacyNotifier;
        }

        public void SendNotification()
        {
            _legacyNotifier.NotifyUsingHttp();
        }
    }
}
