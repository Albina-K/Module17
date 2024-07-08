using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRealExample.Devices
{
    /// <summary>
    /// класс работы с утройством печатающим на холсте
    /// </summary>
    class CanvasPainter : IPainter
    {
        public void Paint()
        {
            Console.WriteLine("Рисуем на холсте");
        }
    }
}
