using System;

namespace LAB_7._Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Day / Age   0 <= age <= 18  18 < age <= 64  64 < age <= 122
            //Weekday 12$	18$	12$
            //Weekend 15$	20$	15$
            //Holiday 5$	12$	10$

            string dayType = Console.ReadLine().ToLower(); ;
            int age = int.Parse(Console.ReadLine());
            double ticketPrice = 0;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            switch (dayType)
            {
                case "weekday":
                    if (age >= 0 && age <= 18)
                    {
                        ticketPrice = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketPrice = 18;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticketPrice = 12;
                    }
                    break;

                case "weekend":
                    if (age >= 0 && age <= 18)
                    {
                        ticketPrice = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketPrice = 20;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticketPrice = 15;
                    }
                    break;

                case "holiday":
                    if (age >= 0 && age <= 18)
                    {
                        ticketPrice = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketPrice = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticketPrice = 10;
                    }
                    break;
                default:
                    break;

            }

            Console.WriteLine($"{ticketPrice}$");

        }
    }
}
