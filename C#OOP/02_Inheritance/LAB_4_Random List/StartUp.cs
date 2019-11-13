using System;
using System.Collections.Generic;

namespace CustomRandomList
{
     class StartUp
    {
        static void Main(string[] args)
        {

            List<string> strList =new List<string>  { "a", "aa", "bbbbb" };
            RandomList RandList = new RandomList();

            RandList.RandomString(strList);
            Console.WriteLine(string.Join(" ",strList ));






        }
    }
}
