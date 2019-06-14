using System;
using System.Collections.Generic;

namespace EX_2._Vowels_Count_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] pass = Console.ReadLine().ToCharArray(); ;
            char[] vowels = { 'A', 'O', 'E', 'I', 'U', 'a', 'o', 'e', 'i', 'u' };
            int count = 0;
            for (int i = 0; i < pass.Length ; i++)
            {
                //if (vowels.Contains(pass[i])) //NO - Array doesn`t have method Contains
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
