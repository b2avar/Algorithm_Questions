using System;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example03
            //Design the algorithm and flowchart to find whether the given
            //integer is zero, positive, or negative.

            Console.WriteLine("Please enter a number :");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("The number you entered is equal to zero");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number you entered is a negative number.");
            }
            else if (number > 0)
            {
                Console.WriteLine("The number you entered is a positive number");
            }
        }
    }
}
