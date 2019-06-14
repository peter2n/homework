using System;

namespace EX_9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();

            void IsPalindrome(string  numString)
            {
                //string numString = number.ToString();
                for (int i = 0; i < numString.Length/2; i++)
                {
                    if (!(numString[i]==numString[numString.Length-i-1]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true");
            }

            while (input!="END")
            {
                IsPalindrome(input);
                input = Console.ReadLine();
            }
        }
    }
}
