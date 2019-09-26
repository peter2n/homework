using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_3_Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> myStack = new Stack<int>() ;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] lineInts = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int command = lineInts[0];

                switch (command)
                {
                    case 1:
                        myStack.Push(lineInts[1]);
                        break;
                    case 2:
                        if (myStack.Count>0)
                        {
                            myStack.Pop();
                        }
                        break;
                    case 3:
                        int[] arrayOfStack = new int[myStack.Count ];
                        myStack.CopyTo(arrayOfStack, 0);
                        Console.WriteLine(arrayOfStack.Max().ToString());
                        break;
                    case 4:
                        int[] maxOfStack = new int[myStack.Count];
                        myStack.CopyTo(maxOfStack, 0);
                        Console.WriteLine(maxOfStack.Min().ToString());
                        break;



                    default:
                        break;
                }

            }

            int[] finalStack = new int[myStack.Count];
            myStack.CopyTo(finalStack, 0);
            Console.WriteLine(string.Join(", ", finalStack));
            
        }
    }
}
