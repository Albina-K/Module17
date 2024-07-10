namespace ChainOfResponsibilityExample
{
    class Client
    {
        void Main()
        {
            //первый обработчик
            Handler handlerOne = new HandlerOne();

            //второй обработчик
            Handler handlerTwo = new HandlerTwo();

            //передача запроса по цепочке и обработка
            handlerOne.Successor = handlerTwo;
            handlerOne.HandleRequest(2);
        }
    }

    ///<summary>
    ///базовый интерфейс обработчика
    /// </summary>
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int condition);
    }

    class HandlerOne : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition == 1)
            {
                //завершение обработки при выполненном условии
            }
            else if (Successor != null)
            {
                //условие не выполнено передаем дальше по цепи
                Successor.HandleRequest(condition);
            }
        }
    }

    ///<summary>
    ///реализация второго обработчика
    /// </summary>
    class HandlerTwo : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition == 2)
            {
                //завершение обработки при выполненном условии
            }
            else if (Successor != null)
                //условие не выполнено - передаем дальше по цепи
                Successor.HandleRequest(condition);
        }
    }

}
