using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_4_Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int biggest = orders.Max();

            //Queue<int> ordersQueue = new Queue<int>();
            Queue<int> ordersQueue = new Queue<int>(orders);

            for (int i = 0; i < orders.Length ; i++)
            {
                int anOrder = ordersQueue.Peek();
                if (qntity>=anOrder)
                {
                    qntity -= anOrder;
                    ordersQueue.Dequeue();
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine(biggest );
            if (ordersQueue.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                int[] ordersLeft = new int[ordersQueue.Count];
                ordersQueue.CopyTo(ordersLeft, 0);
                Console.WriteLine("Orders left: "+string.Join(" ",ordersLeft ));
            }

        }
    }
}
