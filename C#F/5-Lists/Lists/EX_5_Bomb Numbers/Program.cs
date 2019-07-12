using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_5_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList= Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bang = bomb[0];
            int power = bomb[1];

            while (intList.Contains(bang))
            {
                Detonate();
            }
            int sum = intList.Sum();
            Console.WriteLine(sum);

             void Detonate()
            {
                int index = intList.IndexOf(bang);
                int lowIndex = Math.Max(0, index - power);
                int topIndex = Math.Min(intList.Count - 1, index+power);
                for (int i = topIndex; i >= lowIndex; i--)
                {
                    intList.RemoveAt(i);
                }
            }
        }
    }
}
