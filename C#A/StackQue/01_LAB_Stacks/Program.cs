using System;
using System.Collections.Generic;
using System.Text;

namespace _01_LAB_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            char[] inputChars = input.ToCharArray();
            Stack<char> inputStack = new Stack<char>();
            for (int i = 0; i < inputChars.Length ; i++)
            {
                inputStack.Push(inputChars[i]);
            }

            StringBuilder sb = new StringBuilder();

            while (inputStack.Count>1)
            {
                sb.Append(inputStack.Pop());
            }
            sb.Append(inputStack.Peek());
            Console.WriteLine(sb.ToString());


        }
    }
}
