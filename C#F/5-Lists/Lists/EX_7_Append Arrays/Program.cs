using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_7_Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = Console.ReadLine()
                .Split("|")
                .Select(x => x)
                .ToList();

            List<int> listOfList = new List<int>();

            for (int i = 0; i < listOfStrings.Count; i++)
            {
                List<int> ints = listOfStrings[listOfStrings.Count - i - 1]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                listOfList.AddRange(ints);
            }

            Console.WriteLine(string.Join(" ", listOfList));
        }
    }
}
