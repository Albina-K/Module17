using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateRealExample.State
{
    /// <summary>
    /// реализация надземного состояния (лифт на верхних этажах)
    /// </summary>
    class UpperElevatorState : IElevatorState
    {
        public void Up(Elevator elevator)
        {
            Console.WriteLine("Перемещаемся ещё выше");
        }
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся на первый этаж");
            elevator.ElevatorState = new GroundElevatorState();
        }
    }
}
