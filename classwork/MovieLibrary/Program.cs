/*
 * ITSE 1430
 * Spring 2021
 * Sample Implementation
 * Kaleb Dreier
 */
using System;

namespace MovieLibrary
{
    class Program
    {
        static void Main()
        {
            AddMovie();
            DisplayMainMenu();
        }

        private static void DisplayMainMenu ()
        {
            Console.WriteLine("Movie Library");
            Console.WriteLine("-------------");
            Console.WriteLine("A) Add Movie");
            Console.WriteLine("Q) Quit");
            string input = Console.ReadLine();
        }
        static void AddMovie()
        {
            Console.WriteLine("Enter a title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter an optional description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Enter a release year: ");
            int releaseYear = ReadInt32();

            Console.WriteLine("Enter the run length in minutes: ");
            int runLength = ReadInt32();

            Console.WriteLine("Enter the rating: ");
            string rating = Console.ReadLine();

            Console.WriteLine("Is a Classic (Y/N)? ");
            bool isClassic = ReadBoolean();
        }
        static int ReadInt32()
        {
            string input = Console.ReadLine();
            int value = Int32.Parse(input);
            return value;
        }
        static bool ReadBoolean()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            return true;
        }
        void DemoVariables()
        {
            string textInput;
            textInput = "Hello";
            string textInput2 = textInput;
            int x = 10, y = 12;
        }
    }
}
