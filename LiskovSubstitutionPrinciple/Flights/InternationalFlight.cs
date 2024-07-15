using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Flights
{
    /// <summary>
    /// международные рейсы
    /// </summary>
    public class InternationalFlight:Flight
    {
        public InternationalFlight(string name, List<string> passengers = null):base(name, passengers) 
        { }
        //какой-то специфический для международных рейсов функционал
    }
}
