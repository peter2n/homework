using System;

namespace StepsDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            decimal length = decimal.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());

            decimal whole = length * (steps * 4M / 5M + steps % 5);
            decimal part = length * steps * 0.7M / 5M;

            decimal traveled = whole + part;
            decimal percentage = traveled / distance;

            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
        }
    }
}
