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
            //Gather users information
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the month you were born 1-12.");
            int userBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of siblings you have.");
            int userSiblings = int.Parse (Console.ReadLine());

            Console.WriteLine("Please enter your favorite ROYGBIV color, if you do not know ROYGBIV please type \"Help\".");
            string roygbiv = Console.ReadLine();
            string lowerRoygbiv = roygbiv.ToLower();
            //Check if help is needed

            if (lowerRoygbiv == "help")
            {
               Console.WriteLine("ROYGBIV is Red, Orange, Yellow, Green, Blue, Indigo, Violet. Please choose one.");
                roygbiv = Console.ReadLine();
            }
            
            lowerRoygbiv = roygbiv.ToLower();

            //Check users age vs even or odd

            int retireAge;
            if (userAge % 2 == 0)
            {
                retireAge = 20;
            }
            else
            {
                retireAge = 5;
            }
            //Create location
            string location;

            if (userSiblings == 0)
            {
                location = "Italy";
            }
            else if (userSiblings == 1)
            {
                location = "LA";
            }
            else if (userSiblings == 2)
            {
                location = "Miami";
            }
            else if (userSiblings == 3)
            {
                location = "Cleveland";
            }
            else if (userSiblings > 3)
            {
                location = "Pittsburg";
            }
            else
            {
                location = "The corner booth at Applebee's";
            }

            //ROYGBIV variables

            string transportation;
            switch (lowerRoygbiv)
            {
                case "red":
                    transportation = "Mustang";
                    break;
                case "orange":
                    transportation = "Jeep";
                    break;
                case "yellow":
                    transportation = "GMC truck";
                    break;
                case "green":
                    transportation = "yacht";
                    break;
                case "blue":
                    transportation = "jet plane";
                    break;
                case "indigo":
                    transportation = "scooter";
                    break;
                case "Violet":
                    transportation = "Motorcycle";
                    break;
                default:
                    transportation = "Roller Skates";
                    break;
            }

            //Create $$$

            int bank;
            if (userBirth >= 1 && userBirth <= 4)
            {
                bank = 500000;
            }
            else if (userBirth >= 5 && userBirth <= 8)
            {
                bank = 20000;
            }
            else if (userBirth >= 9 && userBirth <= 12)
            {
                bank = 5000;
            }
            else
            {
                bank = 0;
            }

            //Give user their fortune

            Console.WriteLine("{0} {1} will retire in {2} with {3} in the bank, a vacation home in {4} and a {5}.", firstName, lastName, retireAge, bank, location, transportation);
        }
    }
}
