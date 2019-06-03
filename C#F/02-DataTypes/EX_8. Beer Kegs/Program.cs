using System;

namespace EX_8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string modelCurrent;
            decimal radius;
            int height;

            string modelMax="";
            decimal volumeMax = decimal.MinValue;
            decimal volumeCurrent;

            for (int i = 0; i < n; i++)
            {
                modelCurrent = Console.ReadLine();
                radius = decimal.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                volumeCurrent = radius * radius * height * (decimal)Math.PI;

                if (volumeCurrent>volumeMax )
                {
                    volumeMax = volumeCurrent;
                    modelMax = modelCurrent;
                }

                //Console.WriteLine(volumeCurrent);//debug
                //Console.WriteLine(volumeMax);//debug
            }
            Console.WriteLine(modelMax);
        }
    }
}
