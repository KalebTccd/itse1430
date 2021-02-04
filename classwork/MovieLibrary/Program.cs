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
                switch (option)
                {
                    case 'A': AddMovie(); break;
                    case 'V': ViewMovie(); break;
                    case 'Q': done = true; break;
                    default: DisplayError("wait how, unknown command"); break;
                };

            } while (!done);
        }

        private static void ViewMovie ()
        {
            Console.WriteLine($"{title} ({releaseYear})");
            if (runLength > 0)
                Console.WriteLine($"Running Time: {runLength} minutes");
            if (!String.IsNullOrEmpty(rating))
                Console.WriteLine($"MPAA Rating: {rating}");
            Console.WriteLine($"Classic? {(isClassic ? 'Y' : 'N')}");
            if (!String.IsNullOrEmpty(description))
                Console.WriteLine(description);
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
                switch (input)
                {
                    case "A":
                    case "a": return 'A';

                    case "Q":
                    case "q": return 'Q';

                    case "V":
                    case "v": return 'V';

                    default: DisplayError("Invalid option"); break;
                }
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
                    if (result >= minimumValue)
                        return result;
                    else
                        DisplayError("Value must be at least " + minimumValue);
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
