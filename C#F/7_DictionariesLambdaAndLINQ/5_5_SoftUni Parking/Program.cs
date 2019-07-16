using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_5_SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> students = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>x)
                    .ToArray();

                string command = input[0];
                string name = input[1];


                if (command == "register")
                {
                    string plate = input[2];
                    if (!students.ContainsKey(name))
                    {
                        students.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number { plate}");
                    }
                }
                else
                {
                    if (students.ContainsKey(name))
                    {
                        students.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }

                }

                }

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key } => {item.Value }");

            }

            }

        }
    }

