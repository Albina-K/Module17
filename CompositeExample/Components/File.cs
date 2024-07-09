using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Components
{
    /// <summary>
    /// представляет компонент самого низкого уровня 
    /// котрый не может содержать подкомпоненты
    /// </summary>
    class File : Component
    {
        public File(string name) : base(name) { }
        public override void Display()
        {
            Console.WriteLine(Name); 
        }
        //метод для добавления подкомпонентов не поддерживается
        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }
        //метод для удаления подкомпонетов не поддерживается
        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
