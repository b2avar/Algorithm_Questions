using System;

namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example04
            // Make the algorithm that writes the programmer's name on the screen 10 times.

            // Variables
            string name;

            Console.WriteLine("Please enter a name :");
            // read name
            name = Console.ReadLine();

            ReturName(name);
        }

        /// <summary>
        /// Returns string variable 10 times
        /// </summary>
        /// <param name="name">variable to return</param>
        static void ReturName(string name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}
