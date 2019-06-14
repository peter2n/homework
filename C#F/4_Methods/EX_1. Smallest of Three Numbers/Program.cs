using System;

namespace EX_1Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int GetSmallest(int first,int second,int third)
            {
                int smallest=Math.Min(first, second);
                smallest = Math.Min(smallest, third);
                return smallest;
            }

            Console.WriteLine(GetSmallest(n1,n2,n3));
        }
    }
}
