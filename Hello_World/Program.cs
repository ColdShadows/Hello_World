//states the libraries used in this program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//creates namespace called "Hello_World" for the program and all of its classes
namespace Hello_World
{
    //creates a new class called "Program"
    class Program
    {
        //main function for the class
        static void Main(string[] args)
        {
            //creates a string variable to first and last name, and assigns a value to each
            //string firstName = "Travis";
            //string lastName = "Kean";

           
            string firstName = null;
            string lastName = null;

            //Prompts the user to enter both first and last name
            Console.WriteLine("Enter your first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Good job, now enter your last name");
            lastName = Console.ReadLine();
            Console.WriteLine();

            //displays output for 2 seperate lines for different orders of the first and last name, seperated by a comma
            Console.WriteLine(firstName + ", " + lastName + "\n");
            Console.WriteLine(lastName + ", " + firstName + "\n" );

            //Writes the string inside to a command line
            Console.WriteLine("Hello World " + firstName + " " +  lastName);

            //Allows the entering of a string, and finishes after pressing the new line carriage return.
            Console.ReadLine();
        }
    }
}
