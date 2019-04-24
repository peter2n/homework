using System;
using System.Linq;

namespace LinqGroupKeyOrderby
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Group Key OrderBy - query expression
            {
                string sentence = "the quick brown fox jumps over the lazy dog";
                // Split the string into individual words to create a collection.  
                string[] words = sentence.Split(' ');

                // Using query expression syntax.  
                var query = from word in words
                            group word.ToUpper() by word.Length into gr
                            orderby gr.Key
                            select new { Length = gr.Key, Words = gr };

                foreach (var obj in query)
                {
                    Console.WriteLine("Words of length {0}:", obj.Length);
                    foreach (string word in obj.Words)
                        Console.WriteLine(word);
                }
            }

            ///Group Key OrderBy - method based
            {
                string sentence = "the quick brown fox jumps over the lazy dog";
                // Split the string into individual words to create a collection.  
                string[] words = sentence.Split(' ');

                // Using method-based query syntax.  
                var query = words.
                    GroupBy(w => w.Length, w => w.ToUpper()).
                    Select(g => new { Length = g.Key, Words = g }).
                    OrderBy(o => o.Length);

                foreach (var obj in query)
                {
                    Console.WriteLine("Words of length {0}:", obj.Length);
                    foreach (string word in obj.Words)
                        Console.WriteLine(word);
                }
            }


        }//Main
    }
}