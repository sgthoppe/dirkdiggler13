using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METRO_GEAR_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     METRO GEAR SOLID    ");
            Console.WriteLine("Taktikal Commuting Action");
            Console.WriteLine("                         ");
            Console.WriteLine("                         ");
            Console.WriteLine("                         ");
            Console.WriteLine("                         ");
            Console.WriteLine("Two players required     ");
            Console.WriteLine("Press Enter to Play");
        
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("                         ");
                Console.WriteLine("                         ");
                Console.WriteLine("                         ");
                Console.WriteLine("                         ");
                Console.WriteLine("David and Eli are conjoined twins." +
                    "\n" + "They share the same body but different wills." + 
                    "\n" + "David and Eli are about to  ride the Metro Manila Railway System (LRT 1, LRT 2 , MRT 3)." +
                    "\n" + "They have two distinct destinations (metro stations) in mind." + 
                    "\n" + "Obviously, they can't go to their respective destinations simultaneously as they share only one body." + 
                    "\n" + "One destination has to go first." + 
                    "\n" + "David and Eli agreed to take turns in picking stations to go to." + 
                    "\n" + "David and Eli will start in a given station that can be any anywhere in the Metro Manila Railway System." +
                    "\n" + "On each turn, one can only choose to go to any other station that can be reached within the same train system." + 
                    "\n" + "For example, if it is David's turn and the twins are currently in the Katipunan LRT-2 station, David can only choose among the other LRT-2 stations." +
                    "\n" + "There are three types of stations:" +
                    "\n" + "A flip-flop station is a station where the player can switch trains without having to tap-out of the station." +
                    "\n" + "A restricted station is a station where the player can't switch trains." +
                    "\n" + "A junction station is a station that connects two different train systems. Cubao station is a junction station because it connects LRT-2 to MRT-3" +
                    "\n" + "A junction station is also a flip-flop station." +
                    "\n" + "The goal of each player is to get to his respective destination first" );
            }



        }
    }
}
