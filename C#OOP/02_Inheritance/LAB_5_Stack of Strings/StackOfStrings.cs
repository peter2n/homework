using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {

        public bool IsEmpty(Stack<string> strStack)
        {
            return strStack.Count == 0;
        }

        public void AddRange( string[] strArray)
        {
            for (int i = 0; i < strArray.Length; i++)
            {
                this.Push(strArray[i]);
            }

        }


    }
}
