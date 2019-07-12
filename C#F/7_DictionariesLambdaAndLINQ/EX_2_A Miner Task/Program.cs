using System;
using System.Collections.Generic;

namespace EX_2_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, int> precious = new Dictionay<string, int>();
            var precious = new Dictionary<string, int>();

            string input=Console.ReadLine();

            while (input.ToLower()!="stop")
            {
                if (!precious.ContainsKey(input ))
                {
                    precious.Add(input, 0);
                }
                precious[input] += int.Parse(Console.ReadLine());

                input = Console.ReadLine();
            }

            foreach (var item in precious )
            {
                Console.WriteLine($"{item.Key } -> {item.Value }");
            }


        }
    }
}
