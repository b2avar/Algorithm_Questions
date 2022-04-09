using System;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example02
            // Design the algorithm and flowchart that finds out whether the student has passed the course
            // according to the midterm and final grades.

            // Variables
            double midterm, final, average;

            // Midterm exam score
            Console.WriteLine("Please enter your midterm grade :");
            //// Converting to integer type
            midterm = int.Parse(Console.ReadLine());

            // Final exam score
            Console.WriteLine("Please enter your final grade :");
            // Converting to integer type
            final = int.Parse(Console.ReadLine());

            // We assign the result of the mean method to the mean variable.
            average = Average(midterm, final);

            // We check whether it passed the exam with the CourseStatus method.
            CourseStatus(average);

        }

        /// <summary>
        /// Grade average calculator
        /// </summary>
        /// <param name="midterm">midterm exam grade</param>
        /// <param name="final">final exam grade</param>
        /// <returns>average of two exam grades</returns>
        static double Average(double midterm, double final)
        {
            double average;

            average = (midterm * 0.4) + (final * 0.7);

            return average;
        }

        /// <summary>
        /// Function that shows whether you passed the course
        /// </summary>
        /// <param name="average">average exam score</param>
        static void CourseStatus(double average)
        {
            if (average >= 60)
            {
                Console.WriteLine("You passed the course.");
            }
            else
            {
                Console.WriteLine("You failed the course.");
            }
        }
    }
}
