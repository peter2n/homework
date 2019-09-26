using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_5_Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capasity = int.Parse(Console.ReadLine());

            Stack<int> clothesStack = new Stack<int>(clothes);

            int racksCount = 1;
            int currentRackSum = 0;
            for (int i = 0; i < clothes.Length ; i++)
            {
                int nextCloth = clothesStack.Pop  ();
                if (currentRackSum+nextCloth <=capasity )
                {
                    currentRackSum += nextCloth;
                }
                else
                {
                    racksCount++;
                    currentRackSum = nextCloth;
                }

            }

            Console.WriteLine(racksCount );
        }
    }
}
