using System;

namespace testFormatNumeric
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNum = 1234567890;
            Console.WriteLine($"intNum = { intNum}");
            Console.WriteLine($"intNum:D17        {123456789:D17} - integers only");
            Console.WriteLine($"intNum:X          0x{123456789:X}   - integers only");
            Console.WriteLine();

            Double doubleNum = 1234.567890;
            Console.WriteLine($"doubleNum = { doubleNum}");
            Console.WriteLine($"doubleNum:E       {doubleNum:E}");
            Console.WriteLine($"doubleNum:P       {doubleNum:P}");
            Console.WriteLine($"doubleNum:F7      {doubleNum:F7}");

            string[] names = { "Adam", "Bridgette", "Carla", "Daniel", "Ebenezer", "Francine", "George" };
            decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80, 16.75m };

            Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
            for (int ctr = 0; ctr < names.Length; ctr++)
                Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);

            Console.WriteLine("{0,-10} {1,5}\n", "Name", "Hours");
            for (int ctr = 0; ctr < names.Length; ctr++)
                Console.WriteLine("{0,-10} {1,5:N1}", names[ctr], hours[ctr]);

            Console.WriteLine("{0,-20} {1,8}\n", "Name", "Hours");
            for (int ctr = 0; ctr < names.Length; ctr++)
                Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);

        }
    }
}
