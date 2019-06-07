using System;

namespace EX_2._Divison_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //: 2, 3, 6, 7, 10
            //print “Not divisible”. Otherwise print “The number is divisible by { number}”.

            int n = int.Parse(Console.ReadLine());
            int[] divizors = new int[] { 2, 3, 6, 7, 10 };
            int maxDivizor = 0;

            for (int i = 0; i < divizors.Length; i++)
            {
                if (n%divizors[i]==0)
                {
                    maxDivizor = divizors[i];
                }
            }

            if (maxDivizor == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {maxDivizor }");
            }
        }
    }
}
