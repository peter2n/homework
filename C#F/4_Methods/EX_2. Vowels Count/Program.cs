using System;

namespace EX_2._Vowels_Count
{
    class Program
    {
        static void Main()
        {
            string aString = Console.ReadLine();

            int CountVowels(string strParam)
            {
                int count = 0;
                for (int i = 0; i < strParam.Length; i++)
                {
                    if ("AOEIUaoeiu".Contains(strParam[i]))
                    {
                        count++;
                    }
                }
                return count;
            }

            int result = CountVowels(aString);
            Console.WriteLine(result);
        }
    }
}
