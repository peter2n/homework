using System;
using System.Linq;

namespace EX_8._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int targetSum = int.Parse(Console.ReadLine());

            string collectResult = String.Empty;
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                for (int k = i + 1; k < intArr.Length; k++)
                {
                    if ((intArr[i] + intArr[k] == targetSum) && (collectResult.IndexOf(intArr[i].ToString()) < 0))
                    {
                        collectResult = collectResult + intArr[i] + " " + intArr[k] + "\n";
                    }
                }
            }
            Console.WriteLine(collectResult );
        }
    }
}
