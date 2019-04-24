using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Pesho", "Adi", "Gosho","abi", "Tisho", "Mary", "Iva" };

            List<string> namesOrderd = names.OrderBy(x=>x[0]).ToList();
            Console.WriteLine(string.Join(", ",namesOrderd ));
            // "Adi", "Gosho","Iva","Mary", "Tisho", "Pesho","abi"

            //List<string> namesOrderd2 = names.OrderBy(x => x[0], System.Collections.Comparer).ToList();
            //Console.WriteLine(string.Join(", ", namesOrderd2));
            //// "Adi", "Gosho","Iva","Mary", "Tisho", "Pesho","abi"



            ///////////////////////////////////////////////////
            List<string> list = new List<string>();
            list.Add("mississippi"); // Longest.
            list.Add("indus");
            list.Add("danube");
            list.Add("nile"); // Shortest.

            var lengths = from element in list
                          orderby element.Length
                          select element;

            foreach (string value in lengths)
            {
                Console.WriteLine(value);
            }

            //-----------------------
            List<string> list2 = new List<string>();
            list.Add("mississippi"); // Longest.
            list.Add("indus");
            list.Add("danube");
            list.Add("nile"); // Shortest.

            var lengthsDescending = from element in list
                          orderby element.Length ascending
                                    select element;

            foreach (string value in lengthsDescending)
            {
                Console.WriteLine(value);
            }




        }
    }
}
