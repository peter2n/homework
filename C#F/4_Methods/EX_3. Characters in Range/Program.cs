using System;

namespace EX_3._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = Console.ReadLine().ToCharArray()[0];
            char ch2 = Console.ReadLine().ToCharArray()[0];

            void PrintRange(char charPar1,char charPar2)
            {
                int min = Math.Min(charPar1, charPar2);
                int max = Math.Max(charPar1, charPar2);
                for (int i = min + 1; i < max; i++)
                {
                    Console.Write((char )i  );
                    Console.Write(" ");
                }
            }

            PrintRange(ch1, ch2);


        }
    }
}
