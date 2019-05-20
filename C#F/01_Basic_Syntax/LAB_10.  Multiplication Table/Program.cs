using System;

namespace LAB_10.__Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }

        }
    }
}
