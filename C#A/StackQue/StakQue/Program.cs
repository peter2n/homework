using System;
using System.Collections;
using System.Text;

namespace StakQue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack myStack = new Stack(input.ToCharArray());
            StringBuilder sb = new StringBuilder();
            while (myStack.Count>0)
            {
                sb.Append(myStack.Pop());
            }
            Console.WriteLine(  sb.ToString());

        }
    }
}
