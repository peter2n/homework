﻿using System;

namespace LAB_9._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= 2*n; i+=2)
            //{
            //    Console.WriteLine(i);
            //    sum += i;
            //}
            //Console.WriteLine($"Sum: {sum}");

            //**********************************
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(2*i-1);
                sum += 2 * i - 1;
            }
            Console.WriteLine($"Sum: {sum}");





        }
    }
}
