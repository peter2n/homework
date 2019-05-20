﻿using System;

namespace LAB_6._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            //English is spoken in England and USA;
            //Spanish is spoken in Spain, Argentina and Mexico;
            //for the others, we should print "unknown".

            String country = Console.ReadLine();

            switch (country)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
