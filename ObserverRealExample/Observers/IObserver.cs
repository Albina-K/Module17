using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverRealExample.Observers
{
    /// <summary>
    /// Общий интерфейс наблюдателя
    /// </summary>
    interface IObserver
    {
        void Updata(Object o);
    }
}
