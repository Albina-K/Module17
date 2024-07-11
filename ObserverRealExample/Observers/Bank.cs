﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverRealExample.Observers
{
    /// <summary>
    /// реализация банка в качестве наблюдаьеля
    /// </summary>
    class Bank : IObserver
    {
        IObservable stock;
        public Bank(IObservable obs)
        {
            stock = obs;
            stock.RegisterObserver(this);
        }
        public void Updata(object o)
        {
            StockData sData = (StockData)o;
            if(sData.Euro > 85)
                Console.WriteLine($"Банк продает евро по курсу {sData.Euro}");
            else
                Console.WriteLine($"Банк покупает евро по курсу {sData.Euro}");
        }
    }
}
