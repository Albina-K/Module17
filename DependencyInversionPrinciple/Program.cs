namespace DependencyInversionPrinciple
{
    //class VideoAdapter
    //{
    //    public string Text { get; set; }
    //    public Monitor Monitor { get; set; }
    //    public void Display()
    //    {
    //        Monitor.Display(Text);
    //    }
    //}
    //class Monitor
    //{
    //    public void Display(string text)
    //    {
    //        Console.WriteLine(text);
    //    }
    //}
    ///<summary>
    ///универсальный интерфейс для вывода изображения
    /// </summary>
    public interface IHdmiInterface
    {
        void Display(string text);
    }
    class Monitor : IHdmiInterface
    {
        public void Display(string text)
        {
            Console.WriteLine("вывод на монтитор");
        }
    }
    class Tv : IHdmiInterface
    {
        public void Display(string text)
        {
            Console.WriteLine("Вывод на телевизор");
        }
    }
    ///<summary>
    ///Адаптер для вывода изображений
    /// </summary>
    class VideoAdapter
    {
        public string Text { get; set; }
        public IHdmiInterface HdmiInterface { get; set; }
        public VideoAdapter(IHdmiInterface hdmiInterface)
        {
            HdmiInterface = hdmiInterface;
        }
        ///<summary>
        ///метод вывода
        /// </summary>
        public void Display()
        {
            HdmiInterface.Display(Text);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //выводит на монитор
            var connectedMonitor = new VideoAdapter(new Monitor());
            connectedMonitor.Display();

            //выводим на телевизор
            var connectedTV = new VideoAdapter(new Tv());
            connectedTV.Display();
        }
    }
}
