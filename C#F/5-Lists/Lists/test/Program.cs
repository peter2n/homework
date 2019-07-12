using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = "Ivo Johny Tony Bony Mony"
                                                .Split(" ")
                                    .Select(x => x)
                                    .ToList();
            List<string > argList="divide 4 2"
                 .Split(" ")
                                    .Select(x => x)
                                    .ToList();
            DivideStr(argList);

            void DivideStr(List<string> commParam)
            {
                string item = string.Empty;
                int index = int.Parse(commParam[1]);
                int parts = int.Parse(commParam[2]);
                List<string> dividedStr = new List<string>();

                if (index < strList.Count)
                {
                    int partLength = item.Length / parts;

                    for (int i = 0; i < parts; i++)
                    {
                        dividedStr.Add(item.Substring(i, i + partLength - 1));
                    }
                    dividedStr.Add(item.Substring(partLength * (parts - 1), item.Length));
                }

                strList.RemoveAt(index);
                for (int i = 0; i <= parts; i++)

                {
                    strList.Insert(index + i, dividedStr[i]);
                }
            }



        }


    }
}
