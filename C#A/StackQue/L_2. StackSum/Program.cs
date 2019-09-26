using System;
using System.Linq;

namespace L_2._StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console
                            .ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x=>int.Parse(x))
                            .ToArray();






        }
    }
}
