using StateRealExample.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateRealExample
{
    /// <summary>
    /// объект Лифт, которому доступны три состояния
    /// </summary>
    class Elevator
    {
        //хранилище стостояний
        public IElevatorState ElevatorState { get; set; }
        public Elevator(IElevatorState elevatorState)
        {
            ElevatorState = elevatorState;
        }
        //подъем
        public void Up()
        {
            ElevatorState.Up(this);
        }
        
        //спуск
        public void Down()
        {
            ElevatorState.Down(this);
        }
    }
}
