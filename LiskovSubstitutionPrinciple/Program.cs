using LiskovSubstitutionPrinciple.Flights;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //новый список полетов
            var flightsList = new List<Flight>()
            {
                new DomesticFlight("Mow -32", new List<string>() { "Vasya", "Petya" }),
                new DomesticFlight("SPB-14", new List<string>() { "Andrey" })
            };
            //считаем пассажиров
            FlightPassengerCount(flightsList);
        }
        ///<summary>
        ///метод для посчета количества пассажиров
        /// </summary>
        public static void FlightPassengerCount(List<Flight> flights)
        {
            foreach (var flight in flights)
                flight.CountPassengers();
        }
    }
}

