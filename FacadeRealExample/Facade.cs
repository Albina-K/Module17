using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRealExample.Components;

namespace FacadeRealExample
{
    /// <summary>
    /// фасад, скрывающий механизм работы IDE с компонентами,
    /// использующимися при разработке
    /// </summary>
    class Facade
    {
        readonly Editor _editor;
        readonly Compiller _compiller;
        readonly RunTime _runtime;
        public Facade(Editor editor, Compiller compiller, RunTime runtime)
        {
            _editor = editor;
            _compiller = compiller;
            _runtime = runtime;
        }
        //вы ввели код, IDE выполняет с ним примерно следующие действия перед запуском
        public void Start (string sourceCode)
        {
            //пишет в текстовый файл
            _editor.Write(sourceCode);

            //сохраняет текстовый файл
            _editor.Save();

            //вызывает компилятор
            _compiller.Compile();

            //запускает выполнение скомпилированного приложения в среде CLR
            _runtime.Execute();
        }
        //в конце IDE мможет остановить выполнение, вызвав команду в среде выполнения
        public void Stop()
        {
            _runtime.Finish();
        }
    }
}
