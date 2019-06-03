using System;
using System.Linq;

namespace EX_7._Max_Sequence_of_Equal_Elements_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] repetitions = new int[intArr.Length];
            for (int i = 0; i < intArr.Length; i++)
            {
                for (int k = i + 1; k < intArr.Length - i - 1; k++)
                {
                    if (intArr[k] == intArr[i])
                    {
                        repetitions[i]++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            int maxRepetitions = repetitions.Max();
            int index = Array.IndexOf(repetitions, maxRepetitions);
            for (int p = 0; p <= maxRepetitions; p++)
            {
                Console.WriteLine(intArr[index]+" ");
            }

        }
    }
}
