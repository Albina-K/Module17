﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRealExample
{
    class SmsMessage : Message
    {
        public SmsMessage() 
        {
            Console.WriteLine("SMS отправлено");
        }
    }
}
