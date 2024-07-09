using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Components
{
    abstract class Component
    {
        /// <summary>
        /// общий интерфейс для всех компонентов древовидной структуры
        /// </summary>
        public readonly string Name;
        protected Component(string name) 
        {
        this.Name = name;
        }
        #region методы для добавления / удаления подкомпонентов
        public abstract void Display();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        #endregion
    }
}
