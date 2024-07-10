using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealExample.Handlers
{
    abstract class NotificationHandler
    {
        public NotificationHandler Successor { get; set; }
        public abstract void Handler(Receiver receiver);
    }
}
