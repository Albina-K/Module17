using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverRealExample.Observers
{
    /// <summary>
    /// реализация брокера в качестве наблюдателя
    /// </summary>
    class Broker : IObserver
    {
        IObservable stock;
        public Broker(IObservable obs)
        { 
            stock = obs; 
            stock.RegisterObserver(this);        
        }
        public void Updata(object o)
        {
            StockData sData = (StockData)o;
            if (sData.USD > 85)
                Console.WriteLine($"Брокер продает доллары по курсму {sData.USD}");
            else
                Console.WriteLine($"Брокер покупает доллары по курсу {sData.USD}");
        }
        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
