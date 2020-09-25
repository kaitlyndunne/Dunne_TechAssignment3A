/*
    Author: Kaitlyn Dunne
    Date: 09-24-2020
    Comments: Demonstrates the use of iterative methods after getting input from users.
*/

using System;

namespace Dunne_TechAssignment3A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for the user input
            Console.WriteLine("Please enter your name");

            try 
            {
                //Variable will gather data from user input
                string name = Console.ReadLine();

                Console.WriteLine("Hello " + name.ToString() + " - Go Bucs!");
                Console.WriteLine("Press any key to exit the program..");
                Console.ReadKey(true);
            }

            catch
            {
                Console.WriteLine("Please enter your name and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}
