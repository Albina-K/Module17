using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealExample.Handlers
{
    /// <summary>
    /// обработчик смс
    /// </summary>
    class SmsNotificationHandler : NotificationHandler
    {
        public override void Handler(Receiver receiver)
        {
            if (receiver.SmsNotification == true)
                Console.WriteLine("выполнено уведомление по смс");
            else if (Successor != null)
                Successor.Handler(receiver);
        }
    }
}
