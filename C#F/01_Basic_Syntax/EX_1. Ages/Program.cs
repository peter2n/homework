using System;

namespace EX_1._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	0 - 2 – baby; 
            //•	3 - 13 – child; 
            //•	14 - 19 – teenager;
            //•	20 - 65 – adult;
            //•	>= 66 – elder;

            int age = int.Parse(Console.ReadLine());
            string type="";

            if (age<=2 && age>=0)
            {
                type = "baby";
            }
            else if (age <= 13 && age >= 3)
            {
                type = "child";
            }
            else if (age <= 19 && age >= 14)
            {
                type = "teenager";
            }

            else if (age <= 20 && age >= 65)
            {
                type = "adult";
            }

            else if ( age >= 66)
            {
                type = "elder";
            }

            Console.WriteLine(type);
        }
    }
}
