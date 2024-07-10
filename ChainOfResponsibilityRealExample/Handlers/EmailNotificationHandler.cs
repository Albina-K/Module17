using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealExample.Handlers
{
    /// <summary>
    /// обработчик емаил
    /// </summary>
    internal class EmailNotificationHandler : NotificationHandler
    {
        public override void Handler(Receiver receiver)
        {
            if (receiver.EmailNotification == true)
                Console.WriteLine("Выполнено уведомление по емаил");
            else if (Successor != null)
                Successor.Handler(receiver);
        }
    }
}
