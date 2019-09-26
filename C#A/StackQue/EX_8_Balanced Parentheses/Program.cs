using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_8_Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            bool isBalanced = true;

            if (input.Length % 2 == 0)
            {
                Stack<char> stack = new Stack<char>();
                Queue<char> queue = new Queue<char>();
                for (int i = 0; i < input.Length / 2; i++)
                {
                    char currentChar = input[i];
                    if (currentChar != '(' && currentChar != '{' && currentChar != '[')
                    {
                        isBalanced = false;
                        break;
                    }
                    stack.Push(input[i]);
                }

                for (int i = input.Length / 2; i < input.Length; i++)
                {
                    char currentChar = input[i];
                    if (currentChar != ')' && currentChar != '}' && currentChar != ']')
                    {
                        isBalanced = false;
                        break;
                    }
                    queue.Enqueue(currentChar);
                }

                while (stack.Count > 0 && queue.Count > 0)
                {
                    char currentStackChar = stack.Pop();
                    char currentQueueChar = queue.Dequeue();

                    if (currentStackChar == '(' && currentQueueChar != ')')
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (currentStackChar == '{' && currentQueueChar != '}')
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (currentStackChar == '[' && currentQueueChar != ']')
                    {
                        isBalanced = false;
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("NO");
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}