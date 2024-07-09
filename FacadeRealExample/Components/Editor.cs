using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRealExample.Components
{
    /// <summary>
    /// класс для работы с текстовым редактором
    /// </summary>
    class Editor
    {
        //функция написания кода
        public void Write(string sourceCode)
        {
            Console.WriteLine($"Пишем код: {sourceCode}");
        }

        //функция сохранения кода
        public void Save()
        {
            Console.WriteLine("Сщхраняем код");
        }
    }
}
