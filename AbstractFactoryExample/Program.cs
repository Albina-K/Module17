namespace AbstractFactoryExample
{
    ///<summary>
    ///базовый интерфейс абстрактной фабрики
    /// </summary>
    interface IAbstractFactory
    {
        //абстрактный метод для создания продукта А
        AbstractProductA CreateProductA();

        //абстрактный метод для создания продукта В
        AbstractProductB CreateProductB();
    }

    /// <summary>
    /// первая конкретная реализация фабрики
    /// </summary>
    class ConcreteFactory1 : IAbstractFactory
    {
        //конкретная реализация метода для создания продукта А
        public AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        //конкретная реализация метода для создания продукта В
        public AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    /// <summary>
    /// вторая конкретная реализация фабрики
    /// </summary>
    class ConcreteFactory2 : IAbstractFactory
    {
        //конкретная реализация метода для создания продукта А
        public AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        //конкретная реализация метода для создания продукта В
        public AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
    abstract class AbstractProductA
    { }
    abstract class AbstractProductB
    { }
    class ProductA1 : AbstractProductA
    { }
    class ProductB1 : AbstractProductB
    { }
    class ProductA2 : AbstractProductA
    { }
    class ProductB2 : AbstractProductB
    { }

    ///<summary>
    ///Класс в котром нам нужно предусмотреть создание объектов фабрикой
    /// </summary>
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        ///<summary>
        ///конструктор класса, в котором происходит создание объектов фабрики
        /// </summary>
        public Client(IAbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }
        ///<summary>
        ///метлд с нашей бизнесс-логикой, где будут использоваться создаваемые фабрикой объекты
        /// </summary>
        public void Run()
        { }
    }

}