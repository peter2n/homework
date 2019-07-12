using System;
using System.Linq;
using System.Collections.Generic;

namespace LAB_5_Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            //words = words.Select(Console.WriteLine(x)).ToArray();
            Console.WriteLine(string.Join("\n",words));
        }
    }
}
