using System;

namespace EX_6._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < 'a'+n; i++)
            {
                for (int j = 'a'; j< 'a' + n; j++)
                {
                    for (int k = 'a'; k < 'a' + n; k++)
                    {
                        Console.Write((char)i);
                        Console.Write((char)j);
                        Console.Write((char)k);
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
