using System;
using System.Collections.Generic;

namespace EX_1_Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> map =new Dictionary<char, int> () ;

            for (int i = 0; i < input.Length ; i++)
            {
                char currentChar = input[i];

                if (currentChar==' ')
                {
                    continue;
                }

                if (!map.ContainsKey(currentChar))
                {
                    map.Add(currentChar, 0);
                }
                map[currentChar]++;
            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key } -> {item.Value }");


            }


        }
    }
}
