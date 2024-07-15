using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Profiles
{
    /// <summary>
    /// профиль посадка на землю
    /// </summary>
    public class GroundLandingProfile:ILandingProfile
    {
        public void Execute()
        {
            Console.WriteLine(">> Загружен профиль: ПОСАДКА НА ЗЕМЛЮ <<");

            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Опускаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Выпускаем шасси");
            Console.WriteLine("Поднимаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("--ПОСАДКА--");
            Console.WriteLine("Выпускаем тормозной парашют");
        }
    }
}
