using System;
using System.Collections;
using System.Linq;

namespace EX_1_BasicOp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = nsx[0];
            int s = nsx[1];
            int x = nsx[2];

            int[] ints = Console
    .ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

            Stack myStack = new Stack(ints);

            for (int i = 0; i < s && myStack.Count > 0; i++)
            {
                myStack.Pop();
            }
            string result = string.Empty;
            if (myStack.Count == 0)
            {
                result = "0";
            }
            else if (myStack.Contains(x))
            {
                result = "true";
            }
            else
            {
                int[] stackArray = new int[myStack.Count];
                myStack.CopyTo(stackArray, 0);
                result = stackArray.Min().ToString();
            }

            Console.WriteLine(result);
        }
    }
}
