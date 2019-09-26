using System;
using System.Collections;
using System.Linq;

namespace EX_2_BasicQueue
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

            Queue myQueue = new Queue(ints);

            for (int i = 0; i < s && myQueue.Count > 0; i++)
            {
                myQueue.Dequeue ();
            }
            string result = string.Empty;
            if (myQueue.Count == 0)
            {
                result = "0";
            }
            else if (myQueue.Contains(x))
            {
                result = "true";
            }
            else
            {
                int[] queueArray = new int[myQueue.Count];
                myQueue.CopyTo(queueArray, 0);
                result = queueArray.Min().ToString();
            }

            Console.WriteLine(result);
        }
    }
}
