using System;

namespace EX_7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(new[] { ' ' });
            int[] intArr = Array.ConvertAll(strArr, int.Parse);

            int elementMax = 0;
            int countMax = 0;


            for (int i = 0; i < intArr.Length; i++)
            {
                int element = intArr[i];
                int countCurrent = Count(i, element);
                if (countMax < countCurrent)
                {
                    countMax = countCurrent;
                    elementMax = element;
                }
            }
            Console.WriteLine(  new string((char)elementMax,countMax ));

            int Count(int iParam,int elementParam)
            {
                int countRepetitions = 1;
                for (int k = 0; k < intArr.Length - iParam - 1; k++)
                {
                    if (elementParam == intArr[k])
                    {
                        countRepetitions++;
                    }
                    else
                    {
                        return countRepetitions;
                    }
                }
                return countRepetitions;
            }
        }
    }
}
