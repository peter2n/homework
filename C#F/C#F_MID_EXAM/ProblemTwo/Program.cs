using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> arr = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            while (!(input == "End"))
            {
                List<string> command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x).ToList();

                if (command[0].ToLower() == "switch")
                {
                    SwitchSign(command);
                }
                else if (command[0].ToLower() == "change")
                {
                    ChangeValue(command);
                }
                else if (command[0].ToLower() == "sum")
                {
                    SumNegative(command);
                }

                input = Console.ReadLine();
            }

            bool CheckIndex(int idx)
            {
                if (idx >= 0 && idx < arr.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            void SwitchSign(List<string> com)
            {
                int index = int.Parse(com[1]);
                if (!CheckIndex(index))
                {
                    return;
                }
                else
                {
                    arr[index] *= -1;
                }


            }

            void ChangeValue(List<string> com)
            {
                int index = int.Parse(com[1]);
                if (!CheckIndex(index))
                {
                    return;
                }
                else
                {
                    arr[index] = int.Parse(com[2]);
                }

            }

            void SumNegative(List<string> com)
            {
                if (com[1].ToLower()== "negative")
                {
                    List<int> negatives = arr.Where(x => x < 0).ToList();
                    Console.WriteLine(negatives.Sum());
                }
                else if (com[1].ToLower() == "positive")
                {
                    List<int> negatives = arr.Where(x => x >= 0).ToList();
                    Console.WriteLine(negatives.Sum());
                }

                else 
                {
                    //List<int> negatives = arr.Where(x => x >= 0).ToList();
                    Console.WriteLine(arr.Sum());
                }

            }

            arr=arr.Where(x => x >= 0).ToList();
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
