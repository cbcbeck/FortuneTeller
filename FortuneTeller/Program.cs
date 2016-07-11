using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            char yesNo;
            do
            {
                Console.WriteLine("What is your first name?");

                string firstname = Console.ReadLine();

                Console.WriteLine("What is your last name?");
                string lastname = Console.ReadLine();

                Console.WriteLine("What is your age?");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your birth month?");
                string birth = Console.ReadLine();
                string color;
                while (true)
                {
                    Console.WriteLine("What is your favorite color from ROYGBIV? If you do not know what ROYGBIV is please type, Help.");
                    color = Console.ReadLine();

                    if (color.ToLower() == "help")
                    {
                        Console.WriteLine("ROYGBIV = Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    }
                    else if (color.ToLower() == "red")
                    {
                        break;
                    }
                    else if (color.ToLower() == "orange")
                    {
                        break;
                    }
                    else if (color.ToLower() == "yellow")
                    {
                        break;
                    }
                    else if (color.ToLower() == "green")
                    {
                        break;
                    }
                    else if (color.ToLower() == "blue")
                    {
                        break;
                    }
                    else if (color.ToLower() == "indigo")
                    {
                        break;
                    }
                    else if (color.ToLower() == "violet")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid color");

                    }

                }

                Console.WriteLine("How many siblings do you have?");
                int siblings = int.Parse(Console.ReadLine());

                //If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.
                //If the user’s number of siblings is 0, then they will live in __(location), or 1 then they will live in __(location), or 2 then they will live in ___(location), or 3 then they will live in ___(location), or more than 3 then they will live in ____(location).
                //Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation(i.e.car, boat, plane, etc.)
                //If the first letter of the user’s birth month can be found in either their first or last name, then they will have $____ in the bank, or if the second letter of the user’s birth month can be found in either the user’s first or last name, then they will have $____ in the bank, or if the third letter of the user’s birth month can be found in either the user’s first or last name, then they will have $____ in the bank.If there are no common letters, then they will have $____ in the bank.
                //Part 3
                //The user’s fortune should be written as such:
                //[First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
                //After telling the user’s fortune, ask the user if they would like to try again. If they would then the program should start over, otherwise the program should end.
                //Program should be able to handle whether or not a user inputs capital or lowercase letters.
                //Optional Extension Challenge:

                //Give the user the ability to quit the program at any point where the program is looking for user input, by typing “Quit” (should not be case sensitive). The program should print “Nobody likes a quitter...” before ending.
                //Give the user the ability to restart the program at any point where the program is looking for user input by typing “Restart” (should not be case sensitive).

                Random rnd = new Random();
                int retireYear, moneyInBank;
                string loc, transportationMode;
                if (age % 2 == 0)
                    retireYear = rnd.Next(10, 20);
                else
                    retireYear = rnd.Next(20, 30);
                if (siblings == 0)
                    loc = "Dallas";
                else if (siblings == 1)
                    loc = "Houston";
                else if (siblings == 2)
                    loc = "Chicago";
                else if (siblings == 3)
                    loc = "New York";
                else
                    loc = "Boston";

                if (color.ToLower() == "red" || color.ToLower() == "violet")
                    transportationMode = "Car";
                else if (color.ToLower() == "orange" || color.ToLower() == "indigo")
                    transportationMode = "Bus";
                else if (color.ToLower() == "blue" || color.ToLower() == "yellow")
                    transportationMode = "Boat";
                else
                    transportationMode = "Plane";

                if ((firstname.ToLower().Contains(birth[0])) || (lastname.ToLower().Contains(birth[0])))
                {
                    moneyInBank = rnd.Next(10000, 20000);
                }
                else if (firstname.ToLower().Contains(birth[1]) || lastname.ToLower().Contains(birth[1]))
                {
                    moneyInBank = rnd.Next(15000, 25000);
                }
                else if (firstname.ToLower().Contains(birth[2]) || lastname.ToLower().Contains(birth[2]))
                {
                    moneyInBank = rnd.Next(25000, 35000);
                }
                else {
                    moneyInBank = rnd.Next(50000, 70000);
                }

                Console.WriteLine(firstname + " " + lastname + " will retire in " + retireYear + " of years with $" + moneyInBank + " in the bank, a vacation home in " + loc + " and a " + transportationMode);

                Console.WriteLine("Would you like to try again?(y or n) :");
                yesNo = Console.ReadKey().KeyChar;
            } while (yesNo == 'y');
        }
    }
}