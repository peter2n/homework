using System;
using System.Collections.Generic;
using System.Linq;

namespace MORE_1._Encrypt__Sort_and_Print_Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int EncryptedString(char[] inParam)
            {
                int sum = 0;
                for (int i = 0; i < inParam.Length; i++)
                {
                    if ("aeiouAEIOU".Contains(inParam[i]))
                    {
                        sum += inParam[i] * inParam.Length;
                    }
                    else
                    {
                        sum += inParam[i] / inParam.Length;
                    }
                }
                return sum;
            }
            List<int> nameCode = new List<int>();
            for (int k = 0; k < n; k++)
            {
                nameCode.Add(EncryptedString(Console.ReadLine().ToCharArray()));
            }

            //nameCode=nameCode.OrderBy(i => i).ToList();//OK
            nameCode.Sort();//OK
            //nameCode.Reverse();//OK

            for (int j = 0; j < nameCode.Count ; j++)
            {
                Console.WriteLine(nameCode[j]);
            }
        }
    }
}
