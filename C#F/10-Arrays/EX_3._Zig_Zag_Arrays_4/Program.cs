using System;
namespace EX_3._Zig_Zag_Arrays_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] first = new string[n];
            string[] second = new string[n];
            //int i;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' });

                if (i % 2 == 0)
                {
                    first[i] = input[0];
                    second[i] = input[1];
                }
                else
                {
                    second[i] = input[0];
                    first[i] = input[1];
                }
            }

            Console.Write(String.Join(" ", first)+"\n");
            Console.Write(String.Join(" ", second) + "\n");
        }
    }
}
