using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_3_LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            //key materials and everything else is junk

            var keyMaterials = new Dictionary<string, int>();
            var junk = new SortedDictionary<string, int>();
            bool gotLegendaryItem = false; ;

            while (true)
            {
                string line = Console.ReadLine().ToLower();

                string[] input = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x)
                    .ToArray();

                for (int i = 0; i < input.Length / 2; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];//.ToLower();
                    //Shards, Fragments and Motes
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        gotLegendaryItem = AddKeyMaterial(quantity, material);
                    }
                    else
                    {
                        AddJunk(quantity, material);
                    }

                    if (gotLegendaryItem)
                    {
                        PrintAndExit();
                    }
                }
            }


            bool AddKeyMaterial(int qtity, string keyMat)
            {
                if (!keyMaterials.ContainsKey(keyMat))
                {
                    keyMaterials.Add(keyMat, 0);
                }

                keyMaterials[keyMat] += qtity;

                if (keyMaterials[keyMat] >= 250)
                {
                    gotLegendaryItem = true;
                }
                return gotLegendaryItem;
            }


            void AddJunk(int qtity, string junkMat)
            {
                if (!junk.ContainsKey(junkMat))
                {
                    junk.Add(junkMat, 0);
                }

                junk[junkMat] += qtity;

            }

            void PrintAndExit()
            {
                var qtitySortedDictionary = new SortedDictionary<int, string>();
                foreach (var item in keyMaterials)
                {
                    qtitySortedDictionary.Add(item.Value, item.Key);
                }
                qtitySortedDictionary.Reverse();


                foreach (var item in qtitySortedDictionary)
                {
                    Console.WriteLine($"{item.Key}: {item.Value }");
                }


                foreach (var item in junk)
                {
                    Console.WriteLine($"{item.Key}: {item.Value }");
                }


            }

        }
    }
}
