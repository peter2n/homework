using System;

namespace CustomStack
{
    class StartUp
    {
        static void Main(string[] args)
        {

            StackOfStrings myStack = new StackOfStrings();
                myStack.Push("p9d");
            string[] stringsArr =  { "d", "dfsadf", "fdsf" };

            myStack.AddRange(stringsArr);

            Console.WriteLine(string.Join(" ",myStack ));



        }
    }
}
