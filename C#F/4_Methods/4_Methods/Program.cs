using System;

namespace _4_Methods
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            void GetSign(int nParam)
            {
                if (n>0)
                {
                    Console.WriteLine($"The number {n} is positive.");
                }
                else if (n<0)
                {
                    Console.WriteLine($"The number {n} is negative.");
                }
                else
                {
                    Console.WriteLine($"The number {n} is zero.");
                }
            }
            GetSign(n);
        }
    }
}
