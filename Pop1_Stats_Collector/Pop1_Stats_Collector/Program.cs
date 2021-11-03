using System;
using Pop1_Stats_Collector.UserInterfaces;

namespace Pop1_Stats_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#************************************************#");
            Console.WriteLine("# Welcome to the Population: One Stats Collector #");
            Console.WriteLine("#************************************************#");

            StartingUserInterface.MenuLoop();

            Console.WriteLine("Thank you for using Population: One Stats Collecton!");
            Console.Read();

        }
    }
}
