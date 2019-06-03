using System;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rotations = int.Parse(Console.ReadLine());

            string[] stringArray = input.Split(new[] { ' ' });
            string[] stringCopy = new string[stringArray.Length];
            stringArray.CopyTo(stringCopy, 0);

            rotations = rotations % stringArray.Length;

            for (int i = 0; i < stringArray.Length - rotations; i++)
            {
                stringArray[i] = stringArray[i + rotations];
            }

            for (int k = 0; k < rotations; k++)
            {
                stringArray[stringArray.Length - rotations + k] = stringCopy[k];
            }

            Console.WriteLine(String.Join(" ", stringArray));
        }
    }
}
