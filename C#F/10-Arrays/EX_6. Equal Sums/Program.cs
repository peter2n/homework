using System;
using System.Linq;

namespace EX_6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] leftSum = new int[intArray.Length];
            int[] rightSum = new int[intArray.Length];

            for (int i = 0; i < intArray.Length ; i++)
            {            
                for (int k = 0; k <i; k++)
                {
                    leftSum[i] += intArray[k];
                }

                for (int j = i+1; j < intArray.Length; j++)
                {
                    rightSum[i] += intArray[j];
                }
            }

            bool hasEquals = false;//
            for (int m = 0; m < intArray.Length; m++)
            {
                if (leftSum[m]==rightSum[m])
                {
                    Console.WriteLine(m+" ");
                    hasEquals = true;
                }
            }
            if (!hasEquals )
            {
                Console.WriteLine("no");
            }

        }
    }
}
