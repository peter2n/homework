using System;
using System.Collections.Generic;

namespace EX_2._Vowels_Count_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> pass = new List<char>(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < pass.Count; i++)
            {
                if ("AOEIUaoeiu".Contains(pass[i]))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
