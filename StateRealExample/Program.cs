using StateRealExample.State;

namespace StateRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //инициализируем лифт (находится на земле)
            Elevator elevator = new Elevator(new GroundElevatorState());

            elevator.Up(); // подъем наверх
            elevator.Down(); // спуск на землю
            elevator.Down(); // спуск в подвал
        }
    }
}

