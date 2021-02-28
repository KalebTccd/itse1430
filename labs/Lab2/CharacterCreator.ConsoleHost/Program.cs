/*
 * Charcter Creator
 * ITSE 1430
 * Spring 2021
 * Kaleb Dreier
 */
using System;

namespace CharacterCreator.ConsoleHost
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Charcter Creator\r\nITSE 1430\r\nSpring 2021\r\nKaleb Dreier\r\n\r\n");
            MenuLogic();
        }

        static void MenuLogic()
        {
            bool done = false;
            do
            {
                char option = DisplayMenu();
                switch (option)
                {
                    case 'Q': done = QuitProgram(); break;
                    default: DisplayError("wait how, unknown command"); break;
                };
            } while (!done);
        }

        static char DisplayMenu ()
        {
            Console.WriteLine("Charcter Creator");
            Console.WriteLine("-------------");
            Console.WriteLine("Q) Quit");
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Q":
                    case "q": return 'Q';

                    default: DisplayError("Invalid option"); break;
                }
            } while (true);
        }

        static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }

        static bool QuitProgram ()
        {
            Console.WriteLine("Are you sure you want to quit? Y/N: ");
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Y":
                    case "y": return true;

                    case "N":
                    case "n": return false;
                    default: DisplayError("Please enter either Y or N"); break;
                }
            } while (true);
        }
    }
}
