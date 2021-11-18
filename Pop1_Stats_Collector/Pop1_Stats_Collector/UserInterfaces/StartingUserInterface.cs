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
        public static string name;
        public static string path;

        public static async Task MenuLoop()
        {
            while (!Quit)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("Enter from one of the following options:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("<D>isplay Player stats");
                Console.WriteLine("<Q>uit");
                Console.WriteLine(string.Empty);
                var menu_selection = Console.ReadLine().ToUpper();
                await CommandPath(menu_selection, playerCode);
            }
        }

        public static async Task CommandPath(string menu_selection, string playerCode)
        {
            if (menu_selection == "D")
            {
                PlayerStats playerA = new PlayerStats();
                playerCode = await PlayerStats.PullFabId();
                playerA.playerCode = playerCode;
                
                bool Quit2 = false;
                while (!Quit2) {
                    Console.WriteLine("Enter Player Slot (1, 2 or 3) or 0 - No Slot or E - Enemy");
                    string playerSlot = Console.ReadLine().ToUpper();
                    if (playerSlot == "1") { path = @"stats\stats1.txt"; Quit2 = true; }
                    else if (playerSlot == "2") { path = @"stats\stats2.txt"; Quit2 = true; }
                    else if (playerSlot == "3") { path = @"stats\stats3.txt"; Quit2 = true; }
                    else if (playerSlot == "0") { path = @"stats\stats.txt"; Quit2 = true; }
                    else if (playerSlot == "E") { path = @"stats\statsE.txt"; Quit2 = true; }
                    else
                    {
                        Console.WriteLine(string.Empty);
                        Console.WriteLine("{0} is not a valid command. Please try again.", playerSlot);
                        Console.WriteLine(string.Empty);
                    }
                }
                await PlayerStats.PullStats(playerA, playerCode, path);
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
