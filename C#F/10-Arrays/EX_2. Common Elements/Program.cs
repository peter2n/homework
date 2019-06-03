using System;

namespace EX_2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string[] first = inputOne.Split(new[] { ' ' });
            string inputTwo = Console.ReadLine();
            string[] second = inputTwo.Split(new[] { ' ' });

            for (int i = 0; i < second.Length ; i++)
            {
                for (int k = 0; k < first.Length; k++)
                {
                    if (first[k]==second[i])
                    {
                        Console.Write( $"{ first[k]} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
