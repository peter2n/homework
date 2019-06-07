using System;

namespace LAB_3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            void Calculate(string op, double firstN, double secondN)
            //add, multiply, subtract, divide

            {
                double result = 0;
                switch (op)
                {
                    case "add":
                        result = firstN + secondN;
                        break;
                    case "multiply":
                        result = firstN * secondN;
                        break;
                    case "subtract":
                        result = firstN - secondN;
                        break;
                    case "divide":
                        result = firstN / secondN;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(result);
            }
            Calculate(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

        }
    }
}
