using System;
using System.Text;
namespace LAB_1_Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxStars = int.Parse(Console.ReadLine());
            int rowLength = 2 * maxStars - 1;

            for (int i = 1; i <= maxStars; i++)
            {
                PrintRow(maxStars, i);
            }
            for (int i = maxStars - 1; i > 0; i--)
            {
                PrintRow(maxStars, i);
            }

        }

        static void PrintRow(int maxSt, int starCount)
        {
            for (int i = 0; i < maxSt - starCount; i++)
                Console.Write(" ");
            for (int col = 1; col < starCount; col++)
                Console.Write("* ");
            Console.WriteLine("*");
        }

    }
}

