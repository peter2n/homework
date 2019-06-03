using System;

namespace _5.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine())%128;
            int lastChar = int.Parse(Console.ReadLine())%128;
            char character;
            for (int i = firstChar; i <= lastChar; i++)
            {
                character = (char)i;
                Console.Write(character);
                Console.Write(' ');
            }
            Console.WriteLine();


        }
    }
}
