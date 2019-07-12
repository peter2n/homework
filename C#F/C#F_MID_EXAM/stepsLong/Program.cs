using System;

namespace stepsLong
{
    class Program
    {
        static void Main(string[] args)
        {
            long steps = long.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            long distance = long.Parse(Console.ReadLine());

            double whole = length * (steps * 4 / 5 + steps % 5);
            double part = length * steps * 0.7 / 5;

            double traveled = whole + part;
            double percentage = traveled / distance;

            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
        }
    }
}
