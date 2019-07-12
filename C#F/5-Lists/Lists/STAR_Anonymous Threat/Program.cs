using System;
using System.Collections.Generic;
using System.Linq;

namespace STAR_Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x)
                .ToList();

            string input = Console.ReadLine().ToLower();
            while (input != "3:1")
            {
                //  •	merge { startIndex}    { endIndex}
                //•	divide { index}   { partitions}
                List<string> command = input
                                    .Split(" ")
                                    .Select(x => x)
                                    .ToList();

                if (command[0] == "merge")
                {
                    MergeStr(command);
                }
                else
                {
                    DivideStr(command);
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine(string.Join(" ", strList));

            void MergeStr(List<string> commandPar)
            {
                int lowIndex = Math.Max(0, int.Parse(commandPar[1]));
                int topIndex = Math.Min(strList.Count - 1, int.Parse(commandPar[2]));
                string mergedStr = string.Empty;

                for (int i = lowIndex; i <= topIndex; i++)
                {
                    mergedStr = mergedStr + strList[i];
                }

                for (int i = topIndex; i >= lowIndex; i--)
                {
                    strList.RemoveAt(i);
                }

                strList.Insert(lowIndex, mergedStr);
            }

            void DivideStr(List<string> commParam)
            {
                string item = string.Empty;
                int index = int.Parse(commParam[1]);
                int parts = int.Parse(commParam[2]);
                List<string> dividedStr = new List<string>();

                if (index < strList.Count)
                {
                    int partLength = item.Length / parts;

                    for (int i = 0; i < parts; i++)
                    {
                        dividedStr.Add(item.Substring(i, i + partLength - 1));
                    }
                    dividedStr.Add(item.Substring(partLength*(parts-1), item.Length ));
                }

                strList.RemoveAt(index);
                for (int i = 0; i <= parts; i++)

                {
                    strList.Insert(index + i, dividedStr[i]);
                }
            }
        }
    }
}
