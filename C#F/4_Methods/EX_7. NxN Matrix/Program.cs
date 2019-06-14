using System;

namespace EX_7._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nAbs = Math.Abs(n);

            void PrintLine(int colums)
            {
                for (int i = 0; i < colums; i++)
                {
                    Console.Write(colums+" " );//prints ABS
                }
                Console.WriteLine();
            }

            void PrintMatrix(int rows)
            {
                for (int i = 0; i < rows; i++)
                {
                    PrintLine(rows);
                }
            }

            PrintMatrix(nAbs);
        }
    }
}
