using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_4_Hotel_Reservation
{
    enum Discount { VIP = 20, secondTimers = 10, noDiscount = 0 };
    enum Season
    {
        Autumn = 1
, Spring = 2
, Winter = 3
, Summer = 4
    };
    static class PriceCalculator
    {

        public static decimal GetTotalPrice(decimal pricePerDay, int numberOfDays, string season, string discountArg)
        {
            decimal price = 0;

            Discount discount = Discount.noDiscount;
            switch (discountArg)
            {
                case "VIP":
                    discount = Discount.VIP;
                    break;
                case "SecondVisit":
                    discount = Discount.secondTimers;
                    break;
                case "None":
                    discount = Discount.noDiscount;
                    break;
                default:
                    break;
            }

            Season seasonNumber= Season.Autumn;

            switch (season?.ToLower())
            {
                case "autumn":
                    seasonNumber = Season.Autumn;
                    break;
                case "spring":
                    seasonNumber = Season.Spring;
                    break;
                case "winter":
                    seasonNumber = Season.Winter;
                    break;
                case "summer":
                    seasonNumber = Season.Summer;
                    break;
                default:
                    break;
            }

           double discountPercent = (100 - (int)discount) / 100.0;

            price = pricePerDay * numberOfDays * (int)seasonNumber * (decimal)discountPercent;

            return price;
        }
    }
}
