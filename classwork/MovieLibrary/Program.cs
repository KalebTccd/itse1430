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
            bool done = false;
            do
            {
                char option = DisplayMainMenu();
                if (option == 'A')
                    AddMovie();
                if (option == 'V')
                    ViewMovie();
                else if (option == 'Q')
                    done = true;
                else
                    DisplayError("wait how, unknown command");

            } while (!done);
        }

        private static void ViewMovie ()
        {
            Console.WriteLine(title);
            Console.WriteLine(description);
            Console.WriteLine(releaseYear);
            Console.WriteLine(runLength);
            Console.WriteLine(rating);
            Console.WriteLine(isClassic);
        }

        private static char DisplayMainMenu ()
        {
            Console.WriteLine("Movie Library");
            Console.WriteLine("-------------");
            Console.WriteLine("A) Add Movie");
            Console.WriteLine("V) View Movie");
            Console.WriteLine("Q) Quit");
            do
            {
                string input = Console.ReadLine();
                if (input == "A" || input == "a")
                    return 'A';
                else if (input == "V" || input == "v")
                    return 'V';
                else if (input == "Q" || input == "q")
                    return 'Q';
                DisplayError("Invalid option");
            } while (true);
        }
        static void AddMovie()
        {
            Console.WriteLine("Enter a title: ");
            title = Console.ReadLine();

            Console.WriteLine("Enter an optional description: ");
            description = Console.ReadLine();

            Console.WriteLine("Enter a release year: ");
            releaseYear = ReadInt32(1900);

            Console.WriteLine("Enter the run length in minutes: ");
            runLength = ReadInt32(0);

            Console.WriteLine("Enter the rating: ");
            rating = Console.ReadLine();

            Console.WriteLine("Is a Classic (Y/N)? ");
            isClassic = ReadBoolean();
            ViewMovie();
        }
        static string title;
        static string description;
        static int releaseYear;
        static int runLength;
        static string rating;
        static bool isClassic;
        static int ReadInt32 ()
        {
            return ReadInt32(Int32.MinValue);
        }
        static int ReadInt32(int minimumValue)
        {
            do
            {
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out int result))
                {
                    return result;
                }
                DisplayError("Value must be numeric");
            } while (true);
        }

        private static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }

        static bool ReadBoolean()
        {
            do
            {
                string input = Console.ReadLine();
                if (input == "Y" || input =="y")
                    return true;
                else if (input == "N" || input == "n")
                    return false;
                DisplayError("Please enter either Y or N");
            } while (true);
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
//if (x==0)
//{true }
//else
//{false }
//same as
//x == 0 ? true : false
