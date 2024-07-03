using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // создаем объект приложения
            Application app = new Application();

            //запускаем наше приложение (внутри создатся соеденение с базой данных по переданному адресу)
            app.Launch("10.30.60.80");
            Console.WriteLine(app.DbConnection.Configuration);

            //теперь пробуем создать новое соединение с базой данных уже по другому адресу
            app.DbConnection = DbConnection.GetConnectionInstance("10.30.60.81");

            //у нас не получилось создать новое соединение с БД так как объект уже существует
            Console.WriteLine(app.DbConnection.Configuration);
        }
    }
}