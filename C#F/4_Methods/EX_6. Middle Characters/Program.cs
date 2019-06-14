using System;

namespace EX_6._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            void GetMiddle(string inParam)
            {
                int middle = inParam.Length / 2;
                if (inParam.Length % 2 == 0)
                {
                    Console.Write(inParam[middle - 1]);
                }
                Console.WriteLine(inParam[middle]);

            }

            GetMiddle(input);
        }
    }
}
