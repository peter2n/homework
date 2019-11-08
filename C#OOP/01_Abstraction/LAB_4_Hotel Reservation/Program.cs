using System;
using System.Linq;

namespace LAB_4_Hotel_Reservation
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] arg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x).ToArray();

            double doublePricePerDay = double.Parse(arg[0]);

            decimal pricePerDay = (decimal)doublePricePerDay;

            int numberOfDays = int.Parse(arg[1]);

            string season = arg[2];

            //string discountType = arg[3];
            string discountType = arg.Length>3?arg[3]:"0";

            Console.WriteLine(PriceCalculator.GetTotalPrice(pricePerDay, numberOfDays, season, discountType));


        }
    }
}
