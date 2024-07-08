using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRealExample.Devices
{
    /// <summary>
    /// интерфейс устройства, печатающего на холсте
    /// </summary>
    interface IPainter
    {
        void Paint();
    }
}
