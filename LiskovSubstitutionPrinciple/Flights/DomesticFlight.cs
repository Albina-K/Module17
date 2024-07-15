using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Flights
{
    /// <summary>
    /// внутренние рейсы
    /// </summary>
    public class DomesticFlight : Flight
    {
        public DomesticFlight(string name, List<string> passengers = null) : base(name, passengers) 
        {
        
        }
        //какой-то специфический для внутренних рейсов фнукционал
    }
}
