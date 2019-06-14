using System;

namespace EX_5._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int Sum(int first, int second)
            {
                return first + second;
            }

            int Substract(int num1, int num2)
            {
                return num1 - num2;

            }

            int result = Substract(Sum(n1, n2), n3);
            Console.WriteLine(result);
        }
    }
}
