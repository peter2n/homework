using System;

namespace LAB_2._Passed
{
    class LAB_2
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade>=3.0)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
