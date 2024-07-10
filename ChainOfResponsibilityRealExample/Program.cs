using ChainOfResponsibilityRealExample.Handlers;

namespace ChainOfResponsibilityRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true);

            NotificationHandler emailNotificationHandler = new EmailNotificationHandler();
            NotificationHandler voiceNotificationHandler = new VoiceNotificationHandler();
            NotificationHandler smsNotificationHandler = new SmsNotificationHandler();

            emailNotificationHandler.Successor = smsNotificationHandler;
            smsNotificationHandler.Successor = voiceNotificationHandler;

            emailNotificationHandler.Handler(receiver);
        }
    }
}
