using System;
using System.Collections.Generic;

namespace EX_2._Vowels_Count_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //AOEIUaoeiu
            List<char> pass = new List<char>(Console.ReadLine().ToLower());
            int count = 0;
            for (int i = 0; i < pass.Count; i++)
            {
                if (pass[i] == 'a'  || pass[i] == 'a'  || pass[i] == 'o'  || pass[i] == 'e'  || pass[i] == 'i' || pass[i] == 'u' )
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
