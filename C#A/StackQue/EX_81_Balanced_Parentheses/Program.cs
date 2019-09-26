using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_81_Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isBalanced = true;
            string input = Console.ReadLine();

            if (input.Length == 0)
            {
                Console.WriteLine("YES");
                return;
            }

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            else
            {
                Stack<char> stack = new Stack<char>();
                //Queue<char> queue = new Queue<char>();
                for (int i = 0; i < input.Length / 2; i++)
                {
                    char currentChar = input[i];
                    stack.Push(input[i]);
                }

                for (int i = input.Length / 2; i < input.Length; i++)
                {
                    char currentChar = input[i];
                    char popedChar = stack.Pop();

                    switch (currentChar)
                    {
                        case ')':
                            if (popedChar != '(')
                            {
                                isBalanced = false;
                            }
                            break;
                        case ']':
                            if (popedChar != '[')
                            {
                                isBalanced = false;
                            }
                            break;
                        case '}':
                            if (popedChar != '{')
                            {
                                isBalanced = false;
                            }
                            break;
                        default:
                            isBalanced = false;
                            break;
                    }


                }

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