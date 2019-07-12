using System;

namespace stepStep
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine())*100;

            int  shortSteps = steps / 5;
            int longSteps = steps - shortSteps;

            decimal traveled = longSteps * (decimal)length + shortSteps * (decimal)length * 0.7M;

            decimal  percentage = (decimal)traveled / (decimal)distance*100M;

            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");

        }
    }
}
