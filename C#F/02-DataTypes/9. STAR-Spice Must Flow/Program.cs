using System;

namespace _9.STAR_Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yieldStart = int.Parse(Console.ReadLine());
            int dropYield = 10;
            int consumed = 26;
            int yiedlExpected = yieldStart;
            int sum = 0;
            int days = 0;

            while (yiedlExpected >= 100)
            {
                sum = sum + yiedlExpected - consumed;
                if (sum < 0)
                {
                    sum = 0;
                }
                yiedlExpected -= dropYield;
                days++;

            }
            sum -= consumed;
            if (sum < 0)
            {
                sum = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}
