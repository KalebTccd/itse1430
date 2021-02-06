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
            SetUpAccount();
            Console.WriteLine(accountName);
            Console.WriteLine(accountNumber);
            Console.WriteLine(startingBalance);
            do
            {

            } while (!done);
        }
        static void SetUpAccount()
        {
            string temp;
            Console.WriteLine("Enter a name: ");
            accountName = Console.ReadLine();
            do
            {
                Console.WriteLine("Please enter an account number: ");
                temp = Console.ReadLine();
            } while (!CheckAccountNumber(temp));
            accountNumber = temp;
            Console.WriteLine("Please enter a starting amount: ");
            startingBalance = ReadDecimal(0);
        }
        static bool CheckAccountNumber(string value)
        {
            if (value.Length != 12)
            {
                DisplayError("Account Number is not long enough");
                return false;
            } else if (value.EndsWith('0'))
            {
                DisplayError("Account Number cannot have 0 at the end");
                return false;
            } 
            else if (value.StartsWith('0'))
            {
                DisplayError("Account Number cannot have 0 at the beginning");
                return false;
            } 
            else if (!Int64.TryParse(value, out _))
            {
                DisplayError("Account Number can only have numbers");
                return false;
            }
            return true;
        }
        static decimal ReadDecimal ( decimal minimumValue )
        {
            do
            {
                string input = Console.ReadLine();
                if (Decimal.TryParse(input, out decimal result))
                {
                    if (result >= minimumValue)
                        return result;
                    else
                        DisplayError("Value must be at least " + minimumValue);
                }
                DisplayError("Value must be numeric");
            } while (true);
        }
        static char DisplayMenu()
        {
            return 'c';
        }
        static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }
    }
}
