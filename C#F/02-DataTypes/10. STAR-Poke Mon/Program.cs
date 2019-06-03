using System;

namespace _10.STAR_Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            //            You will be given the poke power the Poke Mon has, N – an integer.
            //Then you will be given the distance between the poke targets, M – an integer.
            //Then you will be given the exhaustionFactor Y – an integer.

            int powerN = int.Parse(Console.ReadLine());
            decimal startN = (decimal)powerN;
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int pokes = 0;

            while(powerN >= distanceM)
            {
                powerN -= distanceM;
                pokes++;
                if ((decimal)powerN*2==startN)// && powerN%exhaustionFactorY==0)
                {
                    if (exhaustionFactorY==0)
                    {
                        exhaustionFactorY = 1;//avoid division by ZERO
                    }
                    powerN /= exhaustionFactorY;
                }
            }
            Console.WriteLine(powerN );
            Console.WriteLine(pokes );
        }
    }
}
