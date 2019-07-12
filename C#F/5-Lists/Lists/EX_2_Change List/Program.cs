using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_2_Change_List
{
    class Program
    {
        static void Main()
        {
            //
            

            //
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();//edge - if the list is empty

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                if (command.Contains("delete"))
                {
                    DeleteMember(command);
                }
                else if (command.Contains("insert"))
                {
                    InsertMember(command);
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine(string.Join(" ", input));

            void DeleteMember(string inParam)
            {
                string[] splitDelCommand = inParam
                    .Split(" ")
                    .ToArray();

                int itemToRemove = int.Parse(splitDelCommand[1]);
                for (int i = 0; i < input.Count ; i++)
                {
                    input.Remove(itemToRemove);
                }

            }

            void InsertMember(string inPar)
            {
                string[] splitInsCommand = inPar
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int argumentOne = int.Parse(splitInsCommand[1]);
                int argumentTwo = int.Parse(splitInsCommand[2]);
                if (argumentTwo < input.Count)
                {
                    //public void Insert(int index, T item);
                    input.Insert(index: argumentTwo, item: argumentOne);//SoftUni kind of joke - swap arg1 and arg2 in input
                }
            }
        }
    }
}
