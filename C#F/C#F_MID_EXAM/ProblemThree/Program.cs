using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemThree
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> contacts = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x)
                .ToList();
            bool stopFlag = false;

            while (!stopFlag)
            {
                string input = Console.ReadLine();

                List<string> command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x).ToList();

                if (command[0].ToLower() == "add")
                {
                    AddItem(command);
                }
                else if (command[0].ToLower() == "remove")
                {
                    RemoveItem(command);
                }
                else if (command[0].ToLower() == "export")
                {
                    ExportItems(command);
                }

                else if (command[0].ToLower() == "print")
                {
                    PrintCount(command);
                }
            }

            bool CheckIndex(int idx)
            {
                if (idx >= 0 && idx < contacts.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            void AddItem(List<string> com)
            {
                if (!contacts.Contains(com[1]))
                {
                    contacts.Add(com[1]);
                }
                else
                {
                    int inx = int.Parse(com[2]);
                    if (CheckIndex(inx))
                    {
                        contacts.Insert(inx, com[1]);
                    }
                }
                //debug
                //Console.WriteLine(string.Join(" ", contacts));
                //return;
                //debug
            }

            void RemoveItem(List<string> com)
            {

                int idx = int.Parse(com[1]);
                if(CheckIndex(idx))
                {
                    contacts.RemoveAt(idx);
                }

                //debug
                //Console.WriteLine(string.Join(" ", contacts));
                //return;
                //debug
            }

            void ExportItems(List<string> com)
            {
                int startIndex = int.Parse(com[1]);
                if (!CheckIndex(startIndex))
                {
                    return;
                }

                int exportCount = int.Parse(com[2]);
                int lastIndex = Math.Min(contacts.Count-1, startIndex+ exportCount-1);

                for (int i = startIndex; i <= lastIndex; i++)
                {
                    Console.Write($"{contacts[i]} ");
                }
                Console.WriteLine();
            }

            void PrintCount(List<string> com)
            {
                string order = com[1].ToLower();
                if (order == "reversed")
                {

                    contacts.Reverse();

                }

                Console.WriteLine("Contacts: "  + string.Join(" ", contacts));
                stopFlag = true;
                return;

            }


            //debug
            //Console.WriteLine(string.Join(" ", contacts));

        }
    }
}