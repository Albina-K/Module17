using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRealExample
{
    abstract class MessageSender
    {
        /// <summary>
        /// Абстрактный класс для рассылок
        /// </summary>
        public string From { get; set; }
        public MessageSender (string @from)
        {
            From = @from;
        }
        //фабричный метод
        abstract public Message Send(string text);
    }
}
