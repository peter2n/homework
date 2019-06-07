using System;

namespace MORE_2._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[] seed = { 1 };
            Console.WriteLine(1);
            for (int i = 1; i < n; i++)
            {
                int row = i;
                long[] nextArr = new long[row+1];

                nextArr[0] = 1;
                nextArr[row] = 1;
                for (int k = 1; k < row ; k++)
                {
                    nextArr[k] = seed[k-1]+ seed[k];
                }
                Console.WriteLine(string.Join(" ", nextArr ));
                seed = nextArr;
            }
        }
    }
}
