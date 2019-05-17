using System;

namespace LAB_3._Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade>=3.0)
            {
                Console.WriteLine("Passed!");
            }

            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
