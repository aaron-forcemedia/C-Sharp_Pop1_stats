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
        private static object playerid;

        public static void MenuLoop()
        {
            while (!Quit)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("Enter from one of the following options:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("<C>hange current Username");
                Console.WriteLine("<D>isplay current stats");
                Console.WriteLine("<Q>uit");
                Console.WriteLine(string.Empty);
                var menu_selection = Console.ReadLine().ToUpper();
                CommandPath(menu_selection);
            }
        }

        public static void CommandPath(string menu_selection)
        {
            if (menu_selection == "C")
                Quit = true;
            else if (menu_selection == "D")
            {
                Quit = true;
                //Need to run playerfabid async method from PlayerFabId class but how?
                //I'm going to add a step that allows the user to input their username but right now I am just trying
                //to display one user just to see if it works. 
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
