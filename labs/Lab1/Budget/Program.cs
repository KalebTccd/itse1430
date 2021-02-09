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
        static string s_accountName;
        static string s_accountNumber;
        static decimal s_startingBalance;
        static void Main()
        {
            bool done = false;
            Console.WriteLine("Budget\r\nITSE 1430\r\nSpring 2021\r\nKaleb Dreier\r\n\r\n");
            SetUpAccount();
            do
            {
                char option = DisplayMenu();
                switch(option)
                {
                    case 'D': DepositMoney(); break;
                    case 'Q': done = QuitProgram(); break;
                    default: DisplayError("wait how, unknown command"); break;
                };
            } while (!done);
        }

        static void SetUpAccount()
        {
            string temp;
            Console.WriteLine("Enter a name: ");
            s_accountName = Console.ReadLine();
            do
            {
                Console.WriteLine("Please enter an account number: ");
                temp = Console.ReadLine();
            } while (!CheckAccountNumber(temp));
            s_accountNumber = temp;
            Console.WriteLine("Please enter a starting amount: ");
            s_startingBalance = ReadDecimal(0);
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
            Console.WriteLine("Budget Manager");
            Console.WriteLine("-------------");
            Console.WriteLine($"Account Name: {s_accountName}");
            Console.WriteLine($"Account Number: {s_accountNumber}");
            Console.WriteLine($"Account Balance: {s_startingBalance.ToString("C")}");
            Console.WriteLine("-------------");
            Console.WriteLine("D) Deposit Money");
            Console.WriteLine("Q) Quit");
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "D":
                    case "d": return 'D';

                    case "Q":
                    case "q": return 'Q';

                    default: DisplayError("Invalid option"); break;
                }
            } while (true);
        }

        static void DepositMoney ()
        {
            Console.WriteLine("Please enter a value to deposit: ");
            decimal deposit = ReadDecimal(0);
            if (deposit == 0)
                return;
            Console.WriteLine("Please enter a description: ");
            string description = CheckBlank();
            string category = Console.ReadLine();

            s_startingBalance += deposit;
        }
        static string CheckBlank ()
        {
            string temp;
            do
            {
                temp = Console.ReadLine();
                if(temp == "")
                {
                    DisplayError("Description cannot be blank");
                }
            } while (temp == "");
            return temp;
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
                switch(input)
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
