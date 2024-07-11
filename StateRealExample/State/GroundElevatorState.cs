using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateRealExample.State
{
    /// <summary>
    /// Реализация наземного состояния (лифт на первом этаже)
    /// </summary>
    class GroundElevatorState : IElevatorState
    {
        public void Up(Elevator elevator)
        {
            Console.WriteLine("Поднимаемся на верхний этаж");
            elevator.ElevatorState = new LowerElevatorState();
        }
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся на подвальный этаж");
            elevator.ElevatorState = new LowerElevatorState();
        }
    }
}
