using OpenClosedPrinciple.Profiles;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardComputer = new BoardComputer();

            //посадка на землю
            boardComputer.PerformLanding(new GroundLandingProfile());

            Console.WriteLine();

            //посадка на воду
            boardComputer.PerformLanding(new WaterLandingProfile());
        }
    }
}
