/*
 * Budget
 * ITSE 1430
 * Spring 2021
 * Kaleb Dreier
 */

using System;

namespace Budget
{
    class Program
    {
        static string accountName;
        static string accountNumber;
        static decimal startingBalance;
        static void Main()
        {
            bool done = false;
            Console.WriteLine("Budget\r\nITSE 1430\r\nSpring 2021\r\nKaleb Dreier\r\n\r\n");
            do
            {

            } while (!done);
        }
        static void SetUpAccount()
        {
            string temp;
            accountName = Console.ReadLine();
            do
            {
                temp = Console.ReadLine();
            } while (temp.Length != 12 && temp.EndsWith('0') && temp.StartsWith('0') && temp.);
        }
        static bool NumberCheck(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                    return false;
            }
        }
        static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }
    }
}
