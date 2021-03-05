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
                    case 'E': EditCharacter(); break;
                    case 'D': DeleteCharacter(); break;
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
            Console.WriteLine("E) Edit Character");
            Console.WriteLine("D) Delete Character");
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

                    case "E":
                    case "e": return 'E';

                    case "D":
                    case "d": return 'D';

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
            Console.WriteLine("-------------");
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
                Console.WriteLine("-------------");
            }
        }

        static void EditCharacter()
        {
            if(s_character.Name == null)
            {
                CreateCharacter();
            }
            if(EditProperty("Name",s_character.Name))
            {
                Console.WriteLine("Enter a name: ");
                s_character.Name = GetString();
            }
            if(EditProperty("Profession", s_character.Profession))
            {
                s_character.Profession = GetProfession();
            }
            if (EditProperty("Race", s_character.Race))
            {
                s_character.Race = GetRace();
            }
            if (EditProperty("Biography", s_character.Biography))
            {
                Console.WriteLine("Type in Biography (optional): ");
                s_character.Biography = GetStringNoCheck();
            }
            if (EditProperty("Strength", s_character.Strength.ToString()))
            {
                s_character.Strength = GetStats(0, 100, "Strength");
            }
            if (EditProperty("Intelligence", s_character.Intelligence.ToString()))
            {
                s_character.Intelligence = GetStats(0, 100, "Intelligence");
            }
            if (EditProperty("Agility", s_character.Agility.ToString()))
            {
                s_character.Agility = GetStats(0, 100, "Agility");
            }
            if (EditProperty("Constitution", s_character.Constitution.ToString()))
            {
                s_character.Constitution = GetStats(0, 100, "Constitution");
            }
            if (EditProperty("Charisma", s_character.Charisma.ToString()))
            {
                s_character.Charisma = GetStats(0, 100, "Charisma");
            }
            Console.WriteLine("Character Edited!");
            DisplayCharacter();
        }

        static bool EditProperty(string property, string valProperty)
        {
            Console.WriteLine("Current " + property + " :" + valProperty);
            Console.WriteLine("Would you like to edit " + property + "? Y/N: ");
            return YesNo();
        }

        static void DeleteCharacter ()
        {
            if(s_character.Name == null)
            {
                Console.WriteLine("Cannot delete character cause character doesn't exist!");
                return;
            }
            Console.WriteLine("Are You sure you want to delete you character?");
            if(YesNo())
            {
                s_character.Name.Remove(0);
                s_character.Profession.Remove(0);
                s_character.Race.Remove(0);
                s_character.Biography.Remove(0);
                s_character.Strength = 0;
                s_character.Intelligence = 0;
                s_character.Agility = 0;
                s_character.Constitution = 0;
                s_character.Charisma = 0;
                Console.WriteLine("Character Deleted!");
                Console.WriteLine("-------------");
            }
        }

        static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }

        static bool QuitProgram ()
        {
            Console.WriteLine("Are you sure you want to quit? Y/N: ");
            return YesNo();
        }

        static bool YesNo ()
        {
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
