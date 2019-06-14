using System;

namespace EX_10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            bool IsSum8(int n)
            {
                int sum = 0;
                while (true)
                {
                    sum += n % 10;
                    n = n / 10;
                    if (n == 0)
                    {
                        break;
                    }
                }
                if (sum % 8 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool ContainsOdd(int n)
            {
                while (true)
                {
                    int redux = n % 10;
                    if (redux % 2 == 1)
                    {
                        return true;
                    }
                    n = n / 10;
                    if (n == 0)
                    {
                        return false;
                    }
                }

            }

            for (int i = 0; i <= range; i++)
            {
                if (ContainsOdd(i) && IsSum8(i))
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
