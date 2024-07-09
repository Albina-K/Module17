using FacadeRealExample.Components;

namespace FacadeRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // при запуске IDE инициализирует объекты для работы с компонентами
            Editor textEditor = new Editor();
            Compiller compiller = new Compiller();
            RunTime runTime = new RunTime();

            //наша модель IDE запущена и готова к исполнению
            Facade ide = new Facade(textEditor, compiller, runTime);

            //начинаем писать код и нажимаем кнопку  Start
            ide.Start("Console.WriteLine(\Hello World\");");// запускается выполнение нашей программы
            ide.Stop();
        }
    }
}