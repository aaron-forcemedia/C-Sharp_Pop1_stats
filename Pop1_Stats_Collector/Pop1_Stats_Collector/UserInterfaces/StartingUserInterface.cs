using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pop1_Stats_Collector.UserInterfaces
{
    public static class StartingUserInterface
    {
        public static bool Quit = false;
        public static string playerCode;

        public static async Task MenuLoop()
        {
            while (!Quit)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("Enter from one of the following options:");
                Console.WriteLine("----------------------------------------");
                //Console.WriteLine("<C>hange current Username");
                Console.WriteLine("<D>isplay current stats");
                Console.WriteLine("<Q>uit");
                Console.WriteLine(string.Empty);
                var menu_selection = Console.ReadLine().ToUpper();
                await CommandPath(menu_selection, playerCode);
            }
        }

        public static async Task CommandPath(string menu_selection, string playerCode)
        {
            if (menu_selection == "C")
                Quit = true;
            else if (menu_selection == "D")
            {
                playerCode = await PlayerStats.PullFabId();
                Console.WriteLine(playerCode);
                await PlayerStats.PullStats(playerCode);
            }
            else if (menu_selection == "Q")
                Quit = true;
            else
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("{0} is not a valid command. Please try again.", menu_selection);
                Console.WriteLine(string.Empty);
            }
        }
    }
}
