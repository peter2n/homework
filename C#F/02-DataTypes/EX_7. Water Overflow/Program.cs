using System;

namespace EX_7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int maxCapaicty = 255;
            int capacity = maxCapaicty;

            for (int i = 1; i <= times; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                capacity -= litters;
                if (capacity<0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity += litters;
                }
            }
            Console.WriteLine(maxCapaicty-capacity );

        }
    }
}
