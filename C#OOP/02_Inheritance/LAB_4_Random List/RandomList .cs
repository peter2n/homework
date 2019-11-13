using System;
using System.Collections.Generic;

using System.Text;

namespace CustomRandomList
{
    public class RandomList:List<String >
    {
        public string RandomString(List<string> stringList)
        {
            Random rand = new Random();
            int index = rand.Next(0, stringList.Count);

            string aStringElement = stringList[index];
            stringList.RemoveAt(index);

            return aStringElement;
        }

    }
}
