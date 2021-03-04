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
        static Character s_character = new Character();
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
                    case 'N': CreateCharacter(); break;
                    case 'V': DisplayCharacter(); break;
                    case 'Q': done = QuitProgram(); break;
                    default: DisplayError("wait how, unknown command"); break;
                };
            } while (!done);
        }

        static char DisplayMenu ()
        {
            Console.WriteLine("Charcter Creator");
            Console.WriteLine("-------------");
            Console.WriteLine("N) New Character");
            Console.WriteLine("V) View Character");
            Console.WriteLine("Q) Quit");
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "N":
                    case "n": return 'N';

                    case "V":
                    case "v": return 'V';

                    case "Q":
                    case "q": return 'Q';

                    default: DisplayError("Invalid option"); break;
                }
            } while (true);
        }

        static void CreateCharacter ()
        {
            Console.WriteLine("Enter a name: ");
            s_character.Name = GetString();
            s_character.Profession = GetProfession();
            s_character.Race = GetRace();
            Console.WriteLine("Type in Biography (optional): ");
            s_character.Biography = GetStringNoCheck();
            s_character.Strength = GetStats(0, 100, "Strength");
            s_character.Intelligence = GetStats(0, 100, "Intelligence");
            s_character.Agility = GetStats(0, 100, "Agility");
            s_character.Constitution = GetStats(0, 100, "Constitution");
            s_character.Charisma = GetStats(0, 100, "Charisma");
            Console.WriteLine("Character Created!");
        }

        static string GetString ()
        {
            string temp;
            do
            {
                temp = Console.ReadLine();
                if (temp == "")
                {
                    DisplayError("Field cannot be blank");
                }
            } while (temp == "");
            return temp;
        }

        static string GetStringNoCheck()
        {
            return Console.ReadLine();
        }

        static string GetProfession()
        {
            Console.WriteLine("Choose a Profession \r\n Fighter \r\n Hunter \r\n Priest \r\n Rogue \r\n Wizard");
            Console.WriteLine("Enter a Profession: ");

            string temp = "";
            do
            {
                temp = GetString();
                if(temp != "Fighter" && temp != "Hunter" && temp != "Priest" && temp != "Rogue" && temp != "Wizard")
                {
                    DisplayError("That is not a valid option");
                }
            } while (temp != "Fighter" && temp != "Hunter" && temp != "Priest" && temp != "Rogue" && temp != "Wizard");
            return temp;
        }

        static string GetRace()
        {
            Console.WriteLine("Choose a Race \r\n Dwarf \r\n Elf \r\n Gnome \r\n Half Elf \r\n Human");
            Console.WriteLine("Enter a Race: ");

            string temp = "";
            do
            {
                temp = GetString();
                if (temp != "Dwarf" && temp != "Elf" && temp != "Gnome" && temp != "Half Elf" && temp != "Human")
                {
                    DisplayError("That is not a valid option");
                }
            } while (temp != "Dwarf" && temp != "Elf" && temp != "Gnome" && temp != "Half Elf" && temp != "Human");
            return temp;
        }

        static int GetStats ( int minimumValue, int maxValue, string stat )
        {
            Console.WriteLine("Choose a level for " + stat + " attribute: ");

            do
            {
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out int result))
                {
                    if (result >= minimumValue && result <= maxValue)
                        return result;
                    else if (result < minimumValue)
                        DisplayError("Value must be at least " + minimumValue);
                    else
                        DisplayError("Value must be at most " + maxValue);
                } 
                else
                {
                    return 0;
                }
            } while (true);
        }

        static void DisplayCharacter()
        {
            if(s_character.Name == null)
            {
                Console.WriteLine("A character hasn't been created yet.\r\n Please Add a character first");
                return;
            } 
            else
            {
                Console.WriteLine("Name: " + s_character.Name);
                Console.WriteLine("Profession: " + s_character.Profession);
                Console.WriteLine("Race: " + s_character.Race);
                if(!s_character.Biography.Equals(""))
                {
                    Console.WriteLine("Biography: " + s_character.Biography);
                }
                Console.WriteLine("Strength: " + s_character.Strength);
                Console.WriteLine("Intelligence: " + s_character.Intelligence);
                Console.WriteLine("Agility: " + s_character.Agility);
                Console.WriteLine("Constitution: " + s_character.Constitution);
                Console.WriteLine("Charisma: " + s_character.Charisma);
            }
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
