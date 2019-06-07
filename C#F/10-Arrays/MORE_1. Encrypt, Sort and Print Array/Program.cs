using System;
using System.Linq;

namespace MORE_1._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //string inputString = Console.ReadLine();

            double  Encrypt (string stringParam)
            {
                double  sum = 0;
                for (int i = 0; i < stringParam.Length ; i++)
                {
                    //sum += stringParam[i];

                    if ("aeiouAEIOU".Contains(stringParam[i]))
                    {
                        sum += stringParam[i] * stringParam.Length;
                    }
                    else
                    {
                        sum += stringParam[i] / stringParam.Length;
                    }
                }
                //Console.WriteLine( stringParam + sum);//debug
                return sum;
            }

            double[] stringCodes = new double[n];
            for (int k = 0; k < n; k++)
            {
                stringCodes[k ]= Encrypt(Console.ReadLine());
            }

            for (int j = 0; j < stringCodes.Length ; j++)
            {
                for (int m = 0; m < stringCodes.Length-1; m++)
                {
                    double buffer;
                    if (stringCodes[m]>stringCodes[m+1])
                    {
                        buffer = stringCodes[m + 1];
                        stringCodes[m + 1] = stringCodes[m];
                        stringCodes[m] = buffer;
                    }
                }
            }

            for (int current = 0; current < stringCodes.Length; current++)
            {
                Console.WriteLine(stringCodes[current]);
            }
        }
    }
}
