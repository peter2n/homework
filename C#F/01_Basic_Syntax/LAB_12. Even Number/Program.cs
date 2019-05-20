using System;

namespace LAB_12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int evenN = int.Parse(Console.ReadLine());

                if (evenN%2==0)
                {
                    Console.WriteLine($"The number is: { Math.Abs(evenN)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }

            }
        }
    }
}
