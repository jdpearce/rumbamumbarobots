using System;
using RobotHardware;

namespace GoRumbaMumba
{
    class Program
    {
        private const int WIDTH = 4;
        private const int HEIGHT = 5;

        static void Main()
        {
            var hardware = new Hardware(WIDTH, HEIGHT);

            var cleanCommand = new CleanRumbaMumbaNoObstacles();
            var cleanPath = cleanCommand.Execute(hardware);

            var returnCommand = new ReturnRumbaMumbaNoObstacles();
            var returnPath = returnCommand.Execute(hardware);

            Console.WriteLine("Cleaning Path :");
            foreach (var point in cleanPath)
                Console.WriteLine("{0},{1}", point.X, point.Y);

            Console.WriteLine("Return Path : ");
            foreach (var point in returnPath)
                Console.WriteLine("{0},{1}", point.X, point.Y);

            Console.WriteLine("TotalMovements : {0}", hardware.TotalMovements);
        }
    }
}
