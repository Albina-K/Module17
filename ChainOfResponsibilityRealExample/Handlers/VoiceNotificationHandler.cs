using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealExample.Handlers
{
    /// <summary>
    /// обработчик голосовых сообщений
    /// </summary>
    class VoiceNotificationHandler : NotificationHandler
    {
        public override void Handler(Receiver receiver)
        {
            if (receiver.VoiceNotification == true)
                Console.WriteLine("выполнено уведомление по телефону");
            else if (Successor != null)
                Successor.Handler(receiver);
        }
    }
}
