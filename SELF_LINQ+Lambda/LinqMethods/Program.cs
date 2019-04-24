using System;
using System.Linq;

namespace LinqMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ///x => Console.WriteLine(x)   int.Parse    
                ///OK            
                //var intList = Console.ReadLine().Split().Select(int.Parse).ToList();
                //intList.ForEach(x => Console.WriteLine(x));
            }

            {
                ///Query    
                ///OK
                //string[] names = { "Bill", "Steve", "James", "Mohan" };
                //var myStringQuery = from name in names
                //                    where name.Contains('a')
                //                    select name;
                //foreach (string name in myStringQuery)
                //    Console.Write(name + ' ');
            }

            {
                ///NO - needs var instead of strong type result
                //string[] names = { "Bill", "Steve", "James", "Mohan" };
                //List<string> myStringQuery = from name in names
                //                             where name.Contains('a')
                //                             select name;
                //foreach (string name in myStringQuery)
                //    Console.Write(name + ' ');
            }

            {
                ///Select+Contains  
                ///това не селектира имената, а дава bool дали съдържат символа
                ///OK
                string[] newNames = { "Bill", "Steve", "James", "Mohan" };

                var nameArraySelect = newNames.Select(x => x.Contains('a')).ToArray();//False,False,True,True
                Array.ForEach(nameArraySelect, x => Console.WriteLine(x));

                var nameListSelect = newNames.Select(x => x.Contains('a')).ToList();//False,False,True,True
                nameListSelect.ForEach(x => Console.WriteLine(x));
            }

            {
                ///Where+Contains   
                ///OK
                string[] newNames = { "Bill", "Steve", "James", "Mohan" };
                var nameArrayWhere = newNames.Where(x => x.Contains('a')).ToArray();//James Mohan
                Array.ForEach(nameArrayWhere, x => Console.WriteLine(x));

                var nameListWhere = newNames.Where(x => x.Contains('a')).ToList();//James Mohan
                nameListWhere.ForEach(x => Console.WriteLine(x));
                // ForEach() - difference for Array and List
                // Array.ForEach()
                // nameListWhere.ForEach();
            }






        }
    }
}
