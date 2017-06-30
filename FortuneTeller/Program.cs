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
            //Quit Command
            while (true)
            {
                Console.WriteLine("Welcome to Zoltar! Beware your fortune!");

                //Gather users information

                Console.WriteLine("Enter your first name.");
                string firstName = Console.ReadLine();
                string quit = firstName.ToLower();
                if (quit == "quit")
                    break;
              
                Console.WriteLine("Now enter your last name.");
                string lastName = Console.ReadLine();
                quit = lastName.ToLower();
                if (quit == "quit")
                    break;

                Console.WriteLine("How old are you?");
                string userAgeString = Console.ReadLine();
                userAgeString = userAgeString.ToLower();
                if (userAgeString == "quit")
                    break;

                int userAge = int.Parse(userAgeString);

                Console.WriteLine("In which month were you born 1-12.");
                string userBirthString = Console.ReadLine();
                userBirthString = userBirthString.ToLower();
                if (userBirthString == "quit")
                    break;

                int userBirth = int.Parse(userBirthString);


                Console.WriteLine("How many brothers and/or sister do you have?");
                string userSiblingsString = Console.ReadLine();
                userSiblingsString = userSiblingsString.ToLower();
                if (userSiblingsString == "quit")
                    break;

                int userSiblings = int.Parse(userSiblingsString);

                Console.WriteLine("Enter your favorite ROYGBIV color, if you do not know ROYGBIV please type \"Help\".");
                string roygbiv = Console.ReadLine();
                string lowerRoygbiv = roygbiv.ToLower();

                if (roygbiv == "quit")
                    break;

                
                //Check if help is needed

                if (lowerRoygbiv == "help")
                {
                    Console.WriteLine("ROYGBIV is Red, Orange, Yellow, Green, Blue, Indigo, Violet. Choose one.");
                    roygbiv = Console.ReadLine();
                    lowerRoygbiv = roygbiv.ToLower();
                    if (roygbiv == "quit")
                        break;
                }

                lowerRoygbiv = roygbiv.ToLower();

                //Check users age vs even or odd

                string retireAge;

                if (userAge % 2 == 0)
                {
                    retireAge = "20 years";
                }
                else
                {
                    retireAge = "5 years";
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
                        transportation = "jeep";
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
                        transportation = "motorcycle";
                        break;
                    default:
                        transportation = "roller skates";
                        break;
                }

                //Create $$$

                string bank;
                if (userBirth >= 1 && userBirth <= 4)
                {
                    bank = "$500,000";
                }
                else if (userBirth >= 5 && userBirth <= 8)
                {
                    bank = "$20,000";
                }
                else if (userBirth >= 9 && userBirth <= 12)
                {
                    bank = "$5,000";
                }
                else
                {
                    bank = "$0";
                }

                //Give user their fortune
                Console.WriteLine(" And now the mighty Zoltar will give you your fortune!");
                Console.WriteLine("{0} {1} will retire in {2} with {3} in the bank, a vacation home in {4} and a {5}.", firstName, lastName, retireAge, bank, location, transportation);
                break;
            }
           
        }
    }
}
