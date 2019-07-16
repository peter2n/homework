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
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            var junk = new SortedDictionary<string, int>();
            bool gotLegendaryItem = false;

            while (true)
            {
                string line = Console.ReadLine().ToLower();

                string[] input = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x)
                    .ToArray();

                for (int i = 0; i < input.Length; i += 2)
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
                        return;
                    }
                }
            }


            bool AddKeyMaterial(int qtity, string keyMat)
            {

                keyMaterials[keyMat] += qtity;

                if (keyMaterials[keyMat] >= 250)
                {
                    gotLegendaryItem = true;

                    string legendaryItem = string.Empty;

                    switch (keyMat)
                    {
                        case "shards":
                            legendaryItem = "Shadowmourne";
                            keyMaterials["shards"] -= 250;
                            break;
                        case "fragments":
                            legendaryItem = "Valanyr";
                            keyMaterials["fragments"] -= 250;
                            break;
                        case "motes":
                            legendaryItem = "Dragonwrath";
                            keyMaterials["motes"] -= 250;
                            break;
                    }

                    Console.WriteLine($"{legendaryItem} obtained!");
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
                keyMaterials = keyMaterials
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, y => y.Value);

                foreach (var item in keyMaterials)
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
