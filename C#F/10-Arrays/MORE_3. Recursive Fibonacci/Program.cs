using System;

namespace MORE_3._Recursive_Fibonacci
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine())+1;
            //int enterIF = 0;
            //int enterELSE = 0;
            int oldNMinusOne = 0;
            int newNMinusOne = 0;

            int GetFibonacci(int nParam)
            {
                if (nParam == 1 || nParam == 2)
                {
                    return 1;
                    //enterIF++;
                }
                else
                {
                    //enterELSE++;
                    newNMinusOne = GetFibonacci(nParam - 1);
                    int temp = oldNMinusOne + newNMinusOne;
                    oldNMinusOne = newNMinusOne;
                    return temp;
                }
            }
            Console.WriteLine(GetFibonacci(n));
        }
    }
}
