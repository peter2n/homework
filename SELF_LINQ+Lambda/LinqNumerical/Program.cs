using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqNumerical
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ///x => Console.WriteLine(x)   int.Parse    
                ///OK            
                //var intList = Console.ReadLine().Split().Select(int.Parse).ToList();
                //intList.ForEach(x => Console.WriteLine(x));
            }

            {
                ///Sort()
                int[] arrayInt = new int[] { 1, 7, 96, 2, -6 };

                int max = arrayInt.Max();
                Console.WriteLine(max);

                int min = arrayInt.Min();
                Console.WriteLine(min);

                List<int> listInt = arrayInt.ToList();
                listInt.Sort();
                Console.WriteLine(string.Join(" ", listInt));
                //Console.WriteLine(Enumerable.Join(" ", arraySorted));

                //Enumerable.Join
            }


        }
    }
}
