using System;

namespace EX_8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            long GetFactorial(int num)
            {
                if (num == 1)
                {
                    return 1;
                }
                else
                {
                    return num * GetFactorial(num - 1);
                }
            }

            Double result = 0;
            result = (double)GetFactorial(n1) / GetFactorial(n2);
            Console.WriteLine($"{result:F2}");
        }
    }
}
