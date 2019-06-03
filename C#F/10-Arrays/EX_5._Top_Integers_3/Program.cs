using System;
using System.Linq;

namespace EX_5._Top_Integers_3
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

                int[] intArrayCopy=new int[(intArray.Length)- iParam - 1];
                intArray.CopyTo(intArrayCopy, iParam + 1);
                for (int k = 0; k < intArrayCopy.Length ; k++)
                {
                    if (intArrayCopy[k]>=intArray[iParam])
                    {
                        return false;
                    }
                }
                return true;
            }

        }
    }
}
