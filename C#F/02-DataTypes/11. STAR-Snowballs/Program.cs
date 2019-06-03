using System;
using System.Numerics;

namespace _11.STAR_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsN = int.Parse(Console.ReadLine());
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            int qualitySnow = snowballSnow;
            int qualityTime = snowballTime;
            int qualityQuality = snowballQuality;
            double qualityValueMax = 0.0;
            double qualityValue;

            for (int i = 0; i < snowballsN - 1; i++)
            {
                qualityValue = ValueMethod(snowballSnow, snowballTime, snowballQuality);

                if (qualityValue >= qualityValueMax)
                {
                    qualityValueMax = qualityValue;
                    qualitySnow = snowballSnow;
                    qualityTime = snowballTime;
                    qualityQuality = snowballQuality;
                }
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{qualitySnow} : {qualityTime} = {Math.Round  (qualityValueMax)} ({qualityQuality})");


            double ValueMethod(double snow, double time, double quality)
            {
                double value = Math.Pow(snow / time, quality);
                return value;
            }
            double Value1000(double snow, double time, double quality)
            {
                int factor = 1000;
                double snowFactor = snow * 1000;
                double valueFactor = Math.Pow(snowFactor / time, quality);
                double value = valueFactor / Math.Pow(factor, quality);
                return value;
            }
            double ValueBigInt(int snow, int time,  int quality)
            {
                BigInteger  snowBig = new BigInteger(snow);
                BigInteger timeBig = new BigInteger(time);
                double snowTimeBig = (double)snowBig / (double)timeBig;

                double valueBig = Math.Pow(snowTimeBig, quality);
                return valueBig;
            }
        }
    }
}
