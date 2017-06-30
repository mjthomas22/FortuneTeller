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
            
            //Check if help is needed


        }
    }
}
