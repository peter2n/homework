using System;
using System.Linq;

namespace _4.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {

            //The sum equals: { totalSum}
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            char letter;
            char[] charArray;

            for (int i = 0; i < n; i++)
            {
                charArray = Console.ReadLine().ToArray();
                letter = charArray[0];
                sum += letter;
            }
            Console.WriteLine($"The sum equals: { sum}");
        }
    }
}
