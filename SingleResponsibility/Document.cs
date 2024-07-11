using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    /// <summary>
    /// класс документа
    /// </summary>
    class Document
    {
        public string Text {  get; set; }
        public void ScrollUp()
        {
            Console.WriteLine($"Прокрутка вверх");
        }
        public void ScrollDown()
        {
            Console.WriteLine($"Прокрутка вниз");
        }
        public void ZoomIn()
        {
            Console.WriteLine("Увеличиваем масштаб");
        }
        public void ExportToPdf()
        {
            Console.WriteLine($"Экспортируем в пдф");
            Console.WriteLine(Text);
        }
    }
}
