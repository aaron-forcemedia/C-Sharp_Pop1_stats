﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pop1_Stats_Collector.UserInterfaces
{
    public static class StartingUserInterface
    {
        public static bool Quit = false;

        public static void CommandLoop()
        {
            while (!Quit)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("Enter from one of the following options:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("<C>hange current Username");
                Console.WriteLine("<D>isplay current stats");
                Console.WriteLine("<Q>uit");
                var menu_selection = Console.ReadLine().ToUpper();
                CommandPath(menu_selection);
            }
        }

        public static void CommandPath(string menu_selection)
        {
            if (menu_selection == 'C')
                ChangeUsername();
            else if (menu_selection == 'D')
                DisplayUserStats;
            else if (menu_selection == 'Q')
                Quit = true;
            else
                Console.WriteLine("{0} is not a valid command. Please try again.", menu_selection);
        }
    }
}
