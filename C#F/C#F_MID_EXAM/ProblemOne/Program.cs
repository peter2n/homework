using System;
using System.Numerics;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {

            int steps = int.Parse(Console.ReadLine());
            decimal length = decimal.Parse(Console.ReadLine());
            long distanceCentimeters = long.Parse(Console.ReadLine()) * 100;


            decimal lengthMultiSteps = length * steps;

            decimal centimeters = (lengthMultiSteps / 5M * 4.7M) + (steps % 5) * lengthMultiSteps;


            double percentage = 100 * (double)centimeters / distanceCentimeters;

            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");

            //

        }
    }
}
