using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    /// <summary>
    /// интерфейс с общим фнкционалом
    /// </summary>
    public interface IGeneralPack
    {
        void Drive();
    }

    ///<summary>
    ///интерфейс подключения офф-роуд систем для внедорожника
    /// </summary>
    public interface IOffRoadPack
    {
        void DriveDown();
        void LockDifferential();
        void DescentAssist();
    }
    ///<summary>
    ///интерфейс подключения систем повышенного комфорта
    /// </summary>
    public interface IPremiumPack
    {
        void CruiseControl();
    }

    ///<summary>
    ///интерфейс подключения спортивных систем
    /// </summary> 
    public interface ISportPack
    {
        void FourWheelDrive();
    }

    //Теперь посмотрим, как будет выглядеть софт для седана: 
    ///<summary>
    ///у нас премиум седан, поэтому кроме обычных систем подключаем системы комфорта
    /// </summary>
    public class Sedane : IGeneralPack, IPremiumPack
    {
        public void Drive()
        {
            Console.WriteLine("Едем");
        }
        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }
    }
    //А для внедорожника? 

    ///<summary>
    ///премиум внедородник
    ///</summary>
    public class Suv : IGeneralPack, IPremiumPack, ISportPack, IOffRoadPack
    {
        public void Drive()
        {
            Console.WriteLine("Едем");
        }
        public void CruiseControl()
        {
            Console.WriteLine("Включаем полный привод");
        }
        public void FourWheelDrive()
        {
            Console.WriteLine("Включаем полный привод");
        }
        public void DriveDown()
        {
            Console.WriteLine("Вкючаем системц помощи при спуске");
        }
        public void LockDifferential()
        {
            Console.WriteLine("Включаем блокировку центрального дифференциала");
        }
        public void DescentAssist()
        {
            Console.WriteLine("Включаем систему помощи при спуске");
        }
    }
    //А вот как этим будет пользоваться наш водитель: 
    public class Driver
    {
        public void Drive(IGeneralPack car)
        {
            car.Drive();
        }
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            //наш водитель
            var driver = new Driver();

            //водителю все равно на чем ехать
            Console.WriteLine("Садимся в седан");
            driver.Drive(new Sedane());

            Console.WriteLine();

            Console.WriteLine("Садимся в джип");
            driver.Drive(new Suv());
        }
    }
}
