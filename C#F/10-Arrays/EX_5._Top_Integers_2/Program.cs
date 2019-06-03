using System;
using System.Linq;

namespace EX_5._Top_Integers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < intArray.Length; i++)
            {
                if (IsTop(i))
                {
                    Console.Write($"{intArray[i]} ");
                }
            }

            bool IsTop(int iParam)
            {
                for (int k = iParam + 1; k < intArray.Length; k++)
                {
                    if (intArray[k] >= intArray[iParam])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
