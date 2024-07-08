using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using AdapterRealExample.Devices;

namespace AdapterRealExample
{
    /// <summary>
    /// класс для отрисовки изображений
    /// </summary>
    class ImageDrawer
    {
        //метод запускающий печать с помощью внешнего устройства
        public void DrawWith(IPrinter printer)
        {
            printer.Print();
        }
    }
}
