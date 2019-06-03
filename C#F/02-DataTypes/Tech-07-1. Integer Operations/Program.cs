using System;

namespace Tech_07_1.Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read four integer numbers. Add first to the second, divide(integer) the sum by the third number 
            //and multiply the result by the fourth number. Print the result.

            int number = int.Parse(Console.ReadLine());
            number += int.Parse(Console.ReadLine());
            number /= int.Parse(Console.ReadLine());
            number *= int.Parse(Console.ReadLine());

            Console.WriteLine(number);
        }
    }
}
