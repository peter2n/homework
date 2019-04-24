using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkStringComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                ///empty constructor
                //List<string> listStrings = new List<string>(); 

                List<string> names = new List<string> { "Pesho", "Adi", "Gosho", "Tisho", "Mary", "Iva", };

                ///Where
                List<string> namesA = names.Where(x => x.Contains("A")).ToList();
                Console.WriteLine("A:" + string.Join(" ", namesA));

                ///Where
                List<string> namesAa = names.Where(x => x.Contains("A", StringComparison.OrdinalIgnoreCase)).ToList();
                Console.WriteLine("a:" + string.Join(" ", namesAa));

                List<int> stringLength = names.Select(x => x.Length).ToList();
                Console.WriteLine("string lengths: " + string.Join(", ", stringLength));

                ///sort names by lenght
                var sortedNamesByLength = names.Select(x => new { x, x.Length }).ToList();
                sortedNamesByLength.OrderBy()

                //List<int> stringLonger = names.Where(x => (x.Length > 4)).ToList();
                //List<int> stringLonger = names.Select(x => (x.Length > 4)).ToList();
                //List<int> stringLonger = names.Where((x.Length > 4)).ToList();

                //List<int> stringLonger = names.Where((x.Length > 4)=>x).ToList();
                //List<int> stringLonger = names.Select((x.Length > 4)=>x).ToList();
                //Console.WriteLine("string lengths: " + string.Join(", ", stringLonger));



                var namesLengthQuery =
                    from name in names
                    where name.Length > 4
                    select name;
                foreach (var name in namesLengthQuery)
                {
                    Console.WriteLine(name + " " + name.Length);
                }


            }
        }
    }
