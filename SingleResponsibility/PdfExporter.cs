using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    /// <summary>
    /// экспорт в пдф
    /// </summary>
    class PdfExporter : IExporter
    {
        public void Export(string text)
        {
            Console.WriteLine($"{text} => Экспортировать в пдф");
        }
    }
}
