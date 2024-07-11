using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverRealExample.Observers;

namespace ObserverRealExample
{
    /// <summary>
    /// интерфейс наблюдаемого объекта(источника информации, на котрый подписаны наблюдатели
    /// </summary>
    interface IObservable
    {
        //добавить наблюдателя
        void RegisterObserver(IObserver o);

        //удалить наблюдателя
        void RemoveObserver(IObserver o);

        //уведомление наблюдателей
        void NotifyObservers();
    }
}
