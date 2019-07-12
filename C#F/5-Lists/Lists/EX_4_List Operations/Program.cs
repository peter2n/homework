using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_4_List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // •Add { number} – add number at the end.
            //•	Insert { number}
            //    { index} – insert number at given index.
            //•	Remove { index} – remove at index.
            //•	Shift left { count} – first number becomes last ‘count’ times.
            //•	Shift right { count} – last number becomes first ‘count’ times.
            //"Invalid index"

            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                //int spaceIndex= input.IndexOf(" ");
                //string command = input.Substring(0, spaceIndex);

                string[] inputArray = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                switch (inputArray[0])
                {
                    case "add":
                        AddMember(inputArray);
                        break;
                    case "insert":
                        InsertMember(inputArray);
                        break;
                    case "remove":
                        RemoveMember(inputArray);
                        break;
                    case "shift":
                        Shift(inputArray);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine(String.Join(" ", nums));
            void AddMember(string[] inParam)
            {
                int num = int.Parse(inParam[1]);
                nums.Add(num);
            }
            void RemoveMember(string[] inParam)
            {
                int num = int.Parse(inParam[1]);
                if (num<nums.Count )
                {
                    nums.RemoveAt(num);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            void InsertMember(string[] inParam)
            {
                int num = int.Parse(inParam[1]);
                int index = int.Parse(inParam[2]);
                if (index < nums.Count)
                {
                    nums.Insert(index, num);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            void Shift(string[] inParam)
            {
                int shiftCount = int.Parse(inParam[2]) % nums.Count;
                if (inParam[1] == "left")
                {
                    for (int i = 0; i < shiftCount; i++)
                    {
                        nums.Add(nums[0]);
                        nums.RemoveAt(0);
                    }
                }
                else
                {
                    for (int i = 0; i < shiftCount; i++)
                    {
                        nums.Insert(0, nums[nums.Count - 1]);
                        nums.RemoveAt(nums.Count - 1);
                    }
                }
            }

        }
    }
}
