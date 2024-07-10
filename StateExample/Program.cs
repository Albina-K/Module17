using System.Net.WebSockets;

namespace StateExample
{
    ///<summary>
    ///общий интерфейс, определяющий состояние
    /// </summary>
    abstract class State
    {
        public abstract void Handle(ContextObject contextObject);
    }
    ///<summary>
    ///Сам объект, поведенеи котрого должно изменяться
    /// </summary>
    class ContextObject
    {
        public State State { get; set; }
        public ContextObject(State state)
        {
            State = state; ;
        }
        public void Switch()
        {
            State.Handle(this);
        }
    }
    ///<summary>
    ///первое состояние
    /// </summary>
    class StateOne : State
    {
        public override void Handle(ContextObject contextObject)
        {
            contextObject.State = new StateTwo();
        }
    }
    ///<summary>
    ///второе состояние
    /// </summary>
    class StateTwo : State
    {
        public override void Handle(ContextObject contextObject)
        {
            contextObject.State = new StateOne();
        }
    }
    class Program
    {
        static void Main()
        {
            //создаем обьект сразу в каком-то состоянии
            var contextObject = new ContextObject(new StateOne());

            contextObject.Switch(); // Переход в состояние StateTwo
            contextObject.Switch();// Переход в состояние StateOne
        }
    }
}
