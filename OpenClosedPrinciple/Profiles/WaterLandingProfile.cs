using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Profiles
{
    /// <summary>
    /// профиль для посадки на воду
    /// </summary>
    public class WaterLandingProfile : ILandingProfile
    {
        public void Execute()
        {
            Console.WriteLine(">> Загружен профиль: ПОСАДКА НА ВОДУ <<");

            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Опускаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Поднимаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("--ПОСАДКА--");
        }
    }
}
