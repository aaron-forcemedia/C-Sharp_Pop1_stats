using System;
using System.Threading.Tasks;
using Pop1_Stats_Collector.UserInterfaces;

namespace Pop1_Stats_Collector
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("#************************************************#");
            Console.WriteLine("# Welcome to the Population: One Stats Collector #");
            Console.WriteLine("#************************************************#");
            await StartingUserInterface.MenuLoop();

            Console.WriteLine("Thank you for using Population: One Stats Collecton!");
            Console.Read();

        }
    }
}
