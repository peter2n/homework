using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_1_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> wagons = new List<int>();
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxPassengers = int.Parse(Console.ReadLine());

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                if (input.Contains("add"))
                {
                    AddWagon(input);
                }
                else
                {
                    PutPassengers(input);
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine(string.Join(" ",wagons));

            void AddWagon(string inParam)
            {
                string[] inArray = inParam.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>x).ToArray();

                wagons.Add(int.Parse(inArray[1]));
            }

            void PutPassengers(string inPar)
            {
                int newPassengers = int.Parse(inPar);
                for (int i = 0; i < wagons.Count ; i++)
                {
                    if (wagons[i]+newPassengers<=maxPassengers )
                    {
                        wagons[i] += newPassengers;
                        return;
                    }
                }
            }


        }
    }
}
