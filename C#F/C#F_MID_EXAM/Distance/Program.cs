using System;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            decimal length = decimal.Parse(Console.ReadLine());
            long distanceCentimeters = long.Parse(Console.ReadLine()) * 100;


            decimal whole = length *  (steps*4 / 5 + steps % 5);
            decimal part = length * steps / 5M * 0.7M;
            decimal dist = whole + part;

            double percentage = 100 * (double)dist / distanceCentimeters;
            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");



        }
    }
}
