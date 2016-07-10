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


            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine(firstname);

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine(lastname);

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);

            Console.WriteLine("What is your birth month?");
            string birth = Console.ReadLine();
            Console.WriteLine(birth);
            
            Console.WriteLine("What is your favorite color from ROYGBIV? If you do not know what ROYGBIV is please type, Help.");
            string color = Console.ReadLine();

            if (color == "help")
            {
                Console.WriteLine("ROYGBIV = Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
            }
            else if (color == "red")
            {

            }
            else if (color == "orange")
            {

            }
            else if (color == "yellow")
            {

            }
            else if (color == "green")
            {

            }
            else if (color == "blue")
            {

            }
            else if (color == "indigo")
            {

            }
            else if (color == "violet")
            {

            }
            else
            {
                Console.WriteLine("Invalid color");
            }
            Console.WriteLine(color);



            // colors of ROYGBIV ROUGE, ORANGE, JEUNE, VERDE, BLU, INDIGO, VIOLET
            // int color = rouge;
            // privite static int rouge;
            // Console.WriteLine(color);


            //Console.WriteLine("How many siblings do you have?");
            //     Part 1

            //If the user does not know what ROYGBIV is, ask them to enter “Help” (print with the quotation marks) to get a list of the ROYGBIV colors
            //Ask the user for the number of siblings the user has
            //Part 2

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
          
            Console.ReadKey();
        }
    }
}
