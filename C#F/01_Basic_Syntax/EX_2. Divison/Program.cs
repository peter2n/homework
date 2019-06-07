using System;

namespace EX_2._Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            //: 2, 3, 6, 7, 10
            //print “Not divisible”. Otherwise print “The number is divisible by { number}”.

            int n = int.Parse(Console.ReadLine());
            int maxDivizor = 0;
            int divizor = 0;

            divizor = 2;
            if (n% divizor == 0)
            {
                maxDivizor = divizor;
            }
            divizor = 3;
            if (n % divizor == 0)
            {
                maxDivizor = divizor;
            }
            divizor = 6;
            if (n % divizor == 0)
            {
                maxDivizor = divizor;
            }
            divizor = 7;
            if (n % divizor == 0)
            {
                maxDivizor = divizor;
            }
            divizor = 10;
            if (n % divizor == 0)
            {
                maxDivizor = divizor;
            }

            if (maxDivizor==0)
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
