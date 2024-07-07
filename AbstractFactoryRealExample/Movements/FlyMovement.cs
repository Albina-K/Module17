using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample.Movements
{
    class FlyMovement : IMovement
    {
        public void Start()
        {
            Console.WriteLine("Летим");
        }
    }
}
