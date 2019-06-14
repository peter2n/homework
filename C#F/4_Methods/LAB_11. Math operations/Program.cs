using System;

namespace LAB_11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            char[] op = Console.ReadLine().ToCharArray();
            int second = int.Parse(Console.ReadLine());

            double Calculate(int n1, char opParam,int n2)
            {
                double result=0;
                switch (opParam )
                {
                    case '+':
                        result= n1 + n2;
                        break;
                    case '-':
                        result = n1 - n2;
                        break;
                    case '/':
                        result = (double)n1 / n2;
                        break;
                    case '*':
                        result = n1 * n2;
                        break;
                    default:
                        break;
                }
                return result;
            }

            Console.WriteLine(Calculate(first,op[0],second ));









        }
    }
}
