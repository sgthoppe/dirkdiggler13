using System;
using System.Collections.Generic;

namespace MetroGearSolid
{
    class Program
    {

        static void NumWrite(int q, List<bool> redup)
        {
            if (redup[q] == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(q);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write(q);
            }
        }
        static void instructions()
        {
            Console.WriteLine("Welcome to Metro Gear Solid, a public transportation game made by Militaires Sans Frontieres!                                                                    ");
            Console.WriteLine("                                                                                                                                                                 ");
            Console.WriteLine("David and Eli are conjoined twins who are about to commute in the train system.                                                                                  ");
            Console.WriteLine("However, they have different destinations. Because they share the same body, one's destination has to go first.                                                   ");
            Console.WriteLine("David and Eli agreed to take turns in choosing stations to go to.                                                                                                ");
            Console.WriteLine("The game will be conducted on a map of the entire Metro Manila Railway System.                                                                                   ");
            Console.WriteLine("You as players will have to do a coin toss.                                                                                                                      ");
            Console.WriteLine("Whoever wins the coin toss gets to be the genetically superior twin, David.                                                                                      ");
            Console.WriteLine("The loser of the coin toss becomes the genetically inferior twin, Eli.                                                                                           ");
            Console.WriteLine("The game will assign each player's destination.                                                                                                                  ");
            Console.WriteLine("The player who gets to his or her character's assigned destination first will win!                                                                               ");
            Console.WriteLine("                                                                                                                                                                 ");
            Console.WriteLine("All the train stations in the game serve as the obstacles in the game. There are four types of obstacle stations in the game which the two players have to cross:");
            Console.WriteLine("                                                                                                                                                                 ");
            Console.WriteLine("1) The Switcheroo Stations like all stations in the LRT-2 system, Taft, and Shaw that allow you to switch trains without having to tap out;                      ");
            Console.WriteLine("                                                                                                                                                                 ");
            Console.WriteLine("2) The Limited Stations, where your choice of stations to go to is limited,                                                                                      ");
            Console.WriteLine("   (e.g. if you are northbound from Kamuning Station, the only stations you can go to are Quezon Avenue and North Avenue Stations;)                              ");
            Console.WriteLine("                                                                                                                                                                 ");
            Console.WriteLine("3) The Junction Stations which connect two different train systems such as the Cubao Station which connects the MRT-3 and LRT-2 lines;                           ");
            Console.WriteLine("   These stations are assumed to be one station(e.g., Recto and Doroteo Jose are the same station).                                                              ");
            Console.WriteLine("                                                                                                                                                                 ");
            Console.WriteLine("4) The Dead End Stations. If you end up in this station, there is no where else to go but tap out which means the game is over                                   ");
            Console.WriteLine("   like in the northbound lane of the North Avenue Station or the southbound lane of Baclaran station.                                                           ");
            Console.WriteLine("                                                                                                                                                                 ");
            Console.WriteLine("David always gets to pick first because he is genetically superior.                                                                                              ");

        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int david = 34;
            int eli = 11;
            int current = 1;
            int i = 0;
            bool terminate = false;

            Console.WriteLine("    T  A  K  T  I  K  A  L      C  O  M  M  U  T  I  N  G      A  C  T  I  O  N        ");
            Console.WriteLine(" _    _  ___ _____  ____    __    ___   ___    _    ____    __    __   _   _  ___  ");
            Console.WriteLine("| \\  / ||  _|_   _||  _ \\  /  \\  / _ \\ |  _|  / \\  |  _ \\  /  \\  /  \\ | | | ||   \\ ");
            Console.WriteLine("|  \\/  || |   | |  | | | || /\\ || / \\_|| |   / A \\ | | | || |\\_|| /\\ || | | || |\\ |");
            Console.WriteLine("| \\  / || |_  | |  | |_| || || || | __ | |_ | /_\\ || |_| | \\ \\  | || || | | || || |");
            Console.WriteLine("| |\\/| ||  _| | |  |  _ < | || || ||_ ||  _||  _  ||  _ <   \\ \\ | || || | | || || |");
            Console.WriteLine("| |  | || |   | |  | | | || || || | | || |  | | | || | | | _ \\ \\| || || | | || || |");
            Console.WriteLine("| |  | || |_  | |  | | | || \\/ || \\_/ || |_ | | | || | | || \\| || \\/ || |_| || |/ |");
            Console.WriteLine("|_|  |_||___| |_|  |_| \\_\\ \\__/ |\\__,_||___||_| |_||_| \\_\\ \\__/  \\__/ |___|_||___/ ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("TWO PLAYERS REQUIRED");
            Console.WriteLine("Press F to see instructions.");
            Console.WriteLine("Press any key to start playing.");

            if (Console.ReadKey().Key == ConsoleKey.F)
            {
                Console.WriteLine("");
                instructions();
                Console.WriteLine("Press Enter to Play");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    goto thegame;
                }
            }

            thegame:
            List<List<int>> adjlist = new List<List<int>>();
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15, 3, 18, 20, 21, 22, 24, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            adjlist.Add(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31, 32, 34, 36, 38, 40, 42, 44, 47, 49, 51, 53, 55, 57, 59, 29, 61, 63 });
            adjlist.Add(new List<int> { -1 });
            adjlist.Add(new List<int> { 12, 14, 16, 3, 18, 20, 21, 22, 24, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 11, 13 });
            adjlist.Add(new List<int> { 14, 16, 3, 18, 20, 21, 22, 24, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 11, 13, 15 });
            adjlist.Add(new List<int> { 16, 3, 18, 20, 21, 22, 24, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 11, 13, 15, 17 });
            adjlist.Add(new List<int> { 18, 20, 21, 22, 24, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 11, 13, 15, 17, 19 });
            adjlist.Add(new List<int> { 20, 21, 22, 24, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 11, 13, 15, 17, 19, 21, 22, 24, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 11, 13, 15, 17, 19, 21, 22, 24, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 11, 13, 15, 17, 19, 21, 22, 23 });
            adjlist.Add(new List<int> { 24, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 11, 13, 15, 17, 19, 21, 22, 23, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 11, 13, 15, 17, 19, 21, 22, 23, 25, 26, 28, 29 });
            adjlist.Add(new List<int> { 11, 13, 15, 17, 19, 21, 22, 23, 25, 26, 27 });
            adjlist.Add(new List<int> { 28, 29 });
            adjlist.Add(new List<int> { 11, 13, 15, 3, 17, 19, 21, 22, 23, 25, 26, 27, 29, 30, 31, 32, 34, 36, 38, 40, 42, 44, 10, 46, 48, 50, 52, 54, 56, 58, 60, 63 });
            adjlist.Add(new List<int> { 30, 31, 33, 35, 37, 39, 41, 43, 45, 10, 47, 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 31, 33, 35, 37, 39, 41, 43, 45, 10, 47, 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 32 });
            adjlist.Add(new List<int> { 33, 35, 37, 39, 41, 43, 45, 10, 47, 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 32, 34 });
            adjlist.Add(new List<int> { 35, 37, 39, 41, 43, 45, 10, 47, 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 32, 34, 36 });
            adjlist.Add(new List<int> { 37, 39, 41, 43, 45, 10, 47, 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 32, 34, 36, 38 });
            adjlist.Add(new List<int> { 39, 41, 43, 45, 10, 47, 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 32, 34, 36, 38, 40 });
            adjlist.Add(new List<int> { 41, 43, 45, 10, 47, 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 32, 34, 36, 38, 40, 42 });
            adjlist.Add(new List<int> { 43, 45, 10, 47, 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 32, 34, 36, 38, 40, 42, 44 });
            adjlist.Add(new List<int> { 45, 10, 47, 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 31, 34, 36, 38, 40, 42, 44, 10, 46 });
            adjlist.Add(new List<int> { 47, 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 31, 34, 36, 38, 40, 42, 44, 10, 46, 48 });
            adjlist.Add(new List<int> { 49, 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 31, 34, 36, 38, 40, 42, 44, 10, 46, 48, 50 });
            adjlist.Add(new List<int> { 51, 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 31, 34, 36, 38, 40, 42, 44, 10, 46, 48, 50, 52 });
            adjlist.Add(new List<int> { 53, 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 31, 34, 36, 38, 40, 42, 44, 10, 46, 48, 50, 52, 54 });
            adjlist.Add(new List<int> { 55, 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 31, 34, 36, 38, 40, 42, 44, 10, 46, 48, 50, 52, 54, 56 });
            adjlist.Add(new List<int> { 57, 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 31, 34, 36, 38, 40, 42, 44, 10, 46, 48, 50, 52, 54, 56, 58 });
            adjlist.Add(new List<int> { 59, 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 31, 34, 36, 38, 40, 42, 44, 10, 46, 48, 50, 52, 54, 56, 58, 60 });
            adjlist.Add(new List<int> { 61, 29, 63 });
            adjlist.Add(new List<int> { 30, 31, 31, 34, 36, 38, 40, 42, 44, 10, 46, 48, 50, 52, 54, 56, 58, 60, 29, 62 });
            adjlist.Add(new List<int> { -1 });









            //david goes first bcos he is (supposedly) genetically superior
            while (current != david || current != eli)
            {
                Console.WriteLine("============================================================================================================");
                if (current == 11 || current == 63)
                {
                    terminate = true;
                    break;
                }
                Console.WriteLine("You are currently at station " + current);
                int temp;
                bool validenter = false;
                bool tempfound = false;

                List<bool> lightup = new List<bool>();
                for (int k = 0; k < 64; k++)
                {
                    lightup.Add(false);
                }

                for (int x = 0; x < adjlist[current].Count; x++)
                {
                    lightup[adjlist[current][x]] = true;
                }


                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It's David's turn.");
                    Console.WriteLine("Your destination is station " + david);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It's Eli's turn.");
                    Console.WriteLine("Your destination is station " + eli);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                                                                                            ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pick a selectable(red) station                                                                              ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("               (Balintawak) "); NumWrite(31, lightup); Console.Write("               "); NumWrite(30, lightup); Console.WriteLine(" (Roosevelt)                      ");
                Console.WriteLine("                    _________|_______________|_____                               ");
                Console.Write("     (Monumento) "); NumWrite(33, lightup); Console.Write("-|-"); NumWrite(32, lightup); Console.WriteLine("                           \\	                        ");
                Console.Write("    (5th Avenue) "); NumWrite(35, lightup); Console.Write("-|-"); NumWrite(34, lightup); Console.Write("                         "); NumWrite(12, lightup); Console.Write("-\\-"); NumWrite(11, lightup); Console.WriteLine(" (North Avenue)         ");
                Console.Write("       (R. Papa) "); NumWrite(37, lightup); Console.Write("-|-"); NumWrite(36, lightup); Console.Write("                          "); NumWrite(14, lightup); Console.Write("-\\-"); NumWrite(13, lightup); Console.WriteLine(" (Quezon Avenue)       ");
                Console.Write("   (Abad Santos) "); NumWrite(39, lightup); Console.Write("-|-"); NumWrite(38, lightup); Console.Write("                           "); NumWrite(16, lightup); Console.Write("-|-"); NumWrite(15, lightup); Console.WriteLine(" (Kamuning)           ");
                Console.Write("   (Blumentritt) "); NumWrite(41, lightup); Console.Write("-|-"); NumWrite(40, lightup); Console.WriteLine("                              |                          ");
                Console.Write("       (Tayuman) "); NumWrite(43, lightup); Console.Write("-|-"); NumWrite(42, lightup); Console.Write("                              |______________"); NumWrite(2, lightup); Console.Write("____"); NumWrite(1, lightup); Console.Write("____"); NumWrite(0, lightup); Console.WriteLine(" ");
                Console.Write("       (Bambang) "); NumWrite(45, lightup); Console.Write("-|-"); NumWrite(44, lightup); Console.WriteLine("                              /                          ");
                Console.Write("                    | __________"); NumWrite(9, lightup); Console.Write("____"); NumWrite(8, lightup); Console.Write("___"); NumWrite(7, lightup); Console.Write("___"); NumWrite(6, lightup); Console.Write("___"); NumWrite(5, lightup); Console.Write("_"); NumWrite(4, lightup); Console.Write("_/|- "); NumWrite(3, lightup); Console.WriteLine(" (Cubao)               ");
                Console.Write("  (D.Jose/Recto) "); NumWrite(10, lightup); Console.WriteLine("-_/                                |                          ");
                Console.Write("      (Carriedo) "); NumWrite(47, lightup); Console.Write("-|- "); NumWrite(46, lightup); Console.Write("                          "); NumWrite(18, lightup); Console.Write("-|-"); NumWrite(17, lightup); Console.WriteLine(" (Santolan-Annapolis)  ");
                Console.Write("       (Central) "); NumWrite(49, lightup); Console.Write("-|- "); NumWrite(48, lightup); Console.WriteLine("                             |                          ");
                Console.Write("       (UN Ave.) "); NumWrite(51, lightup); Console.Write("-|- "); NumWrite(50, lightup); Console.WriteLine("                             |                          ");
                Console.Write("     (Pedro Gil) "); NumWrite(53, lightup); Console.Write("-|- "); NumWrite(52, lightup); Console.Write("                          "); NumWrite(20, lightup); Console.Write("-|-"); NumWrite(19, lightup); Console.WriteLine(" (Ortigas)            ");
                Console.Write("  (Quirino Ave.) "); NumWrite(55, lightup); Console.Write("-|- "); NumWrite(54, lightup); Console.Write("                             /- "); NumWrite(21, lightup); Console.WriteLine(" (Shaw Boulevard)     ");
                Console.Write("     (Vito Cruz) "); NumWrite(57, lightup); Console.Write("-|- "); NumWrite(56, lightup); Console.Write("                            /- "); NumWrite(22, lightup); Console.WriteLine(" (Boni)                ");
                Console.Write("     (Gil Puyat) "); NumWrite(59, lightup); Console.Write("-|- "); NumWrite(58, lightup); Console.Write("                        "); NumWrite(24, lightup); Console.Write("-/- "); NumWrite(23, lightup); Console.WriteLine(" (Guadalupe)            ");
                Console.Write("      (Libertad) "); NumWrite(61, lightup); Console.Write("-|- "); NumWrite(60, lightup); Console.Write("                          /- "); NumWrite(25, lightup); Console.WriteLine(" (Buendia)               ");
                Console.Write("     (EDSA/Taft) "); NumWrite(29, lightup); Console.Write("-|_____________________________/- "); NumWrite(26, lightup); Console.WriteLine(" (Ayala)                  ");
                Console.Write("      (Baklaran) "); NumWrite(63, lightup); Console.Write("-|- "); NumWrite(62, lightup); Console.Write("        "); NumWrite(28, lightup); Console.Write("-|-"); NumWrite(27, lightup); Console.WriteLine(" (Magallanes)                            ");

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                while (validenter == false)
                {
                    Console.Write("Enter the number of the station (red) you want to go to: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    bool validint = int.TryParse(Console.ReadLine(), out temp);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (validint == false)
                    {
                        Console.WriteLine("You did not enter a valid integer");
                    }
                    else
                    {
                        for (int x = 0; x < adjlist[current].Count; x++)
                        {
                            if (temp == adjlist[current][x])
                            {
                                i++;
                                current = temp;
                                tempfound = true;
                                validenter = true;

                                break;
                            }
                        }
                        if (tempfound == false)
                        {
                            Console.WriteLine("You can't go to that station.");
                        }
                    }
                }
                if (current == david)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Solid Snake Wins");
                    break;
                }
                else if (current == eli)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Liquid Wins");
                    break;
                }
                if (terminate == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You just ended up in a dead-end station, you've nowhere to go now. GAME OVER");
                }
            }
        }
    }
}
