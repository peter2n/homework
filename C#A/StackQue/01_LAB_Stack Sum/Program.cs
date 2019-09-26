using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_LAB_Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList= Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>int.Parse(x))
                .ToList();

            Stack<int> inputStack = new Stack<int>();

            for (int i = 0; i < inputList.Count ; i++)
            {
                inputStack.Push(inputList[i]);
            }







        }
    }
}
