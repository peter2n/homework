using System;

namespace EX_3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Friday Saturday    Sunday
            //Students    8.45    9.80    10.46
            //Business    10.90   15.60   16
            //Regular 15  20  22.50

            int n= int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double price = 0.0;

            switch (type)
            {
                case "students":
                    switch (day)
                    {
                        case "friday":
                            price =8.45;
                            break;
                        case "satuday":
                            price = 9.80;
                            break;
                        case "sunday":
                            price = 10.46;
                            break;
                    }
                    break;

                case "business":
                    switch (day)
                    {
                        case "friday":
                            price = 10.90;
                            break;
                        case "satuday":
                            price = 15.60;
                            break;
                        case "sunday":
                            price = 16;
                            break;
                    }
                    break;

                case "regular":
                    switch (day)
                    {
                        case "friday":
                            price = 15;
                            break;
                        case "satuday":
                            price = 20;
                            break;
                        case "sunday":
                            price = 22.50;
                            break;
                    }
                    break;




            }


        }
    }
}
