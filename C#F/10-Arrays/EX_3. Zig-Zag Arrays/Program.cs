using System;

namespace EX_3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] first = new string[n];
            string[] second = new string[n];
            //int i;

            for (int i = 0; i < n; i += 2)
            {
                string[] inputOne = Console.ReadLine().Split(new[] { ' ' });
                string[] inputTwo = Console.ReadLine().Split(new[] { ' ' });
                Array.Reverse(inputTwo);

                first[i] = inputOne[0];
                second[i] = inputOne[1];

                first[i + 1] = inputTwo[0];
                second[i + 1] = inputTwo[1];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{first[i]} ");
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{second[i]} ");
            }
            Console.WriteLine();
        }
    }
}
