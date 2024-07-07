using System.Text;
using AbstractFactoryRealExample.Factories;

namespace AbstractFactoryRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;

            //создание дракона черрез фабрику
            var dragon = new Monster(new DragonFactory());
            dragon.Move();
            dragon.Hit();

            Console.WriteLine();

            // создание орка через фабрику
            var orc = new Monster(new OrcFactory());
            orc.Move();
            orc.Hit();

            Console.WriteLine();
            Console.WriteLine("Всем конец");
        }
    }
}