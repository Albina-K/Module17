using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Flights
{
    /// <summary>
    /// базовый класс для всех полетов
    /// </summary>
    public abstract class Flight
    {
        public string Name;
        public List<string> PassengerList;

        public Flight(string name, List<string> passangers = null)
        {
            Name = name;
            PassengerList = passangers ?? new List<string>();
        }

        //подсчет количества пассажиров
        public void CountPassengers()
        {
            Console.WriteLine($"На рейсе {Name} {PassengerList.Count} пассажиров");
        }
    }
}
