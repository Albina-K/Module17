namespace Facade
{
    public class SystemOne
    {
        public void S1Method()
        {

        }
    }

    public class SystemTwo
    {
        public void S2Method()
        {

        }
    }
    public class SystemThree
    {
        public void S3Method()
        {

        }
    }

    ///<summary>
    ///фасад, скрывающий от клиентского кода взаимодействие с системами
    /// </summary>
    public class Facade
    {
        private SystemOne _systemOne;
        private SystemTwo _systemTwo;
        private SystemThree _systemThree;

        ///<summary>
        ///метод-конструктор принимает системы на вход
        /// </summary>
        public Facade(SystemOne systemOne, SystemTwo systemTwo, SystemThree systemThree)
        {
            _systemOne = systemOne;
            _systemTwo = systemTwo;
            _systemThree = systemThree;
        }
        //методы для клиента, через которые он взаимодействует с системами
        public void OperationOne()
        {
            _systemOne.S1Method();
            _systemTwo.S2Method();
            _systemThree.S3Method();
        }
        public void OperationTwo()
        {
            _systemTwo.S2Method();
            _systemThree.S3Method();
        }
    }

    /// <summary>
    /// клинтский код
    /// </summary>
    class Client
    {
        public void Main()
        {
            //создание фасада
            Facade facade = new Facade(new SystemOne(), new SystemTwo(), new SystemThree());

            //Вызовы
            facade.OperationOne();
            facade.OperationTwo();
        }
    }
}
