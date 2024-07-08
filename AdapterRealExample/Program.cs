using AdapterRealExample.Devices;

namespace AdapterRealExample
{
    class Program
    {
        static void Main (string[] args)
        {
            //нам надо отрисовать изображение на бумаге и холсте
            //запускаем класс для отрисовки
            var imageDrawer = new ImageDrawer ();

            //создаем класс для работы с бумажным принтером
            PaperPrinter paperPrinter = new PaperPrinter ();
            //запускаем отрисовку на бумаге
            imageDrawer.DrawWith(paperPrinter);

            //теперь нужна печать на холсте
            CanvasPainter canvasPainter = new CanvasPainter ();

            //используем адаптер
            IPrinter imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);

            //запускаем печать на холсте
            imageDrawer.DrawWith(imagePrinter);
            Console.Read();
        }
    }
}
