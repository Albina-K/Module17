namespace FactoryMethodExample
{
    /// <summary>
    /// Базовый абстрактный класс
    /// </summary>
    abstract class BaseClass
    { }

    /// <summary>
    /// Конкретная реализация A
    /// </summary>
    class ConcreteClassA : BaseClass
    { }

    /// <summary>
    /// Конкретная реализация B
    /// </summary>
    class ConcreteClassB : BaseClass
    { }

    /// <summary>
    /// Абстрактный класс, от которого наследуются конкретные реализации
    /// </summary>
    abstract class Creator
    {
        /// Фабричный метод, который будет переопределен в классах-наследниках
        public abstract BaseClass FactoryMethod();
    }

    /// <summary>
    /// Конкретная реализация A
    /// </summary>
    class ConcreteCreatorA : Creator
    {
        //  Переопределенный Фабричный метод здесь возвращает конкретную реализацию
        public override BaseClass FactoryMethod()
        {
            return new ConcreteClassA();
        }
    }
    /// <summary>
    /// Конкретная реализация B
    /// </summary>
    class ConcreteCreatorB : Creator
    {
        //  Переопределенный Фабричный метод здесь возвращает конкретную реализацию
        public override BaseClass FactoryMethod()
        {
            return new ConcreteClassB();
        }
    }
}
