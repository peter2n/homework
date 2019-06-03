using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capasity = int.Parse(Console.ReadLine());

            int couses = people / capasity;
            if (people%capasity > 0)
            {
                couses++;
            }
            Console.WriteLine(couses );
        }
    }
}
