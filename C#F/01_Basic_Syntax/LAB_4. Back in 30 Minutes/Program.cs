using System;

namespace LAB_4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesBefore = int.Parse(Console.ReadLine()) * 60 + int.Parse(Console.ReadLine());
            int minutesPlus = minutesBefore + 30;
            int hoursAfter = minutesPlus / 60;
            int minutesAfter = minutesPlus % 60;

            Console.WriteLine($"{hoursAfter}:{minutesAfter:d2}");
        }
    }
}
