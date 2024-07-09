using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Components
{
    /// <summary>
    /// представляет папку - компонент, который может содержать другие компоненты
    /// здесь реализован механизм для добавления / удаления новых компонентов
    /// </summary>
    class Folder : Component
    {
        List<Component> subFolders = new List<Component>();
        public Folder (string name) : base(name) { }
        //метод для добавления новых компонентов
        public override void Add(Component component)
        {
            subFolders.Add(component);
            Console.WriteLine($"В {this.Name} добалено : {component.Name}");
        }
        //метод для удаления
        public override void Remove(Component component)
        {
            subFolders.Remove(component);
            Console.WriteLine($"Из {this.Name} удалено: {component.Name}");
        }
        //метод для отображения нижестоящих компонентов
        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} содержит");
            foreach(Component component in subFolders) 
                component.Display();
        }
    }
}
