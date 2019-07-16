using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_6_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> cources = new Dictionary<string, List<string>>();
            string line = Console.ReadLine();
            while (line.ToLower()!="end")
            {
                string[] command = line
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x)
                    .ToArray();

                string cource = command[0];
                string student = command[1];
                if (student[0]>96 && student[0]<123)
                {
                    Char.ToUpper(student[0]);

                }

                if (!cources.ContainsKey(cource ))
                {
                    cources.Add(cource, new List<string>());
                }

                if (!cources[cource].Contains(student))
                {
                    cources[cource].Add(student);
                }



                cources = cources
                    .OrderByDescending(x => x.Value.Count)
                    .ToDictionary(x => x.Key, y => y.Value);

                line = Console.ReadLine();
            }


            foreach (var item in cources)
            {
                item.Value.Sort();

                Console.WriteLine($"{item.Key }: {item.Value.Count}");

                foreach (var name in item.Value)
                {
                    Console.WriteLine($"-- {name}");
                }

            }

        }
    }
}
