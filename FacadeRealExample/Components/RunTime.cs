using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRealExample.Components
{
    /// <summary>
    /// класс для вызова среды выполнения CLR
    /// </summary>
    class RunTime
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение приложений");
        }
        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }
    }
}
