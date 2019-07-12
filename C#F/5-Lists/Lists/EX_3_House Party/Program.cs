using System;
using System.Collections.Generic;

namespace EX_3_House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //-"{name} is not going!"

            int num = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                int spacePosition = input.IndexOf(" ");
                string name = input.Substring(0, spacePosition);

                if (input.Contains("not"))
                {
                     RemoveName(name);
                }
                else 
                {
                    AddName(name);
                }
            }

            Console.WriteLine(string.Join("\n", names));



            void RemoveName(string namePar)
            {

                if (names.Contains(namePar))
                {
                    names.Remove(namePar);
                }
                else
                {
                    Console.WriteLine($"{ namePar} is not in the list!" );
                }

            }

            void AddName(string nameParam)
            {
                if (names.Contains(nameParam))
                {
                    Console.WriteLine($"{nameParam} is already in the list!");
                }
                else
                {
                    names.Add(nameParam);
                }
            }
        }
    }
}
