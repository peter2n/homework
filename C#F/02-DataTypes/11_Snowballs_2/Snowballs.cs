using System;

namespace _11_Snowballs_2
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            //            •	The number of snowballs(N) will be an integer in range[0, 100].
            //•	The snowballSnow is an integer in range[0, 1000].
            //•	The snowballTime is an integer in range[1, 500].
            //•	The snowballQuality is an integer in range[0, 100].

            int n = int.Parse(Console.ReadLine());
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            //snowballValue by the following formula:
            //(snowballSnow / snowballTime) ^ snowballQuality

            double snowballValue = (snowballSnow / snowballTime) ^ snowballQuality;



        }
    }
}
