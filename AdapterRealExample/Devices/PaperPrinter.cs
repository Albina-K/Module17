using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRealExample.Devices
{
    class PaperPrinter : IPrinter
    {
        /// <summary>
        /// класс для работы с принтером
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Печатаем на бумаге");
        }
    }
}
