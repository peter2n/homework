using System;
using System.Linq;

namespace EX_5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < intArray.Length; i++)
            {
                bool isTop = true;
                for (int k = i + 1; k < intArray.Length - i - 1; k++)
                {
                    if (intArray[k] >= intArray[i])
                    {
                        isTop = false;
                        break;
                    }
                }
                if (!isTop)
                {
                    continue;
                }
                Console.Write($"{intArray[i]} ");
            }


        }
    }
}
