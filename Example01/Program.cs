﻿using System;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example01
            // Design an algorithm and flowchart that finds and shows the larger
            // of two numbers given different from each other.

            // Variables
            int firstNumber, secondNumber, bigNumber;

            // First number
            Console.WriteLine("Please enter the first number :");
            // Converting to integer type
            firstNumber = int.Parse(Console.ReadLine());

            // Second number
            Console.WriteLine("Please enter the second number :");
            // Converting to integer type
            secondNumber = int.Parse(Console.ReadLine());

            // Is the first number greater than the second number?
            if (firstNumber > secondNumber)
            {
                // If yes, the big number is the first number.
                bigNumber = firstNumber;    
            }
            // if not
            else
            {
                // the big number is the second number.
                bigNumber = secondNumber;
            }

            // Printing big number to console.
            Console.WriteLine("Big number : {0}", bigNumber);

        }
    }
}
