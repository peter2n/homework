using System;

namespace EX_1_ClassBoxData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double  lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //try
            //{
            Box box = new Box(lenght, width, height);



            Console.WriteLine($"Surface Area - {box.CalcSurfaceArea ():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.CalcLateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.CalcVolume():f2}");
            //}
            //catch (ArgumentException e) 
            //{
                
            //}
        }
    }
}
