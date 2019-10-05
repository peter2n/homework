//namespace EX_6._Jagged_Array_Manipulator
using System;
using System.Linq;

namespace EX_6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[n][];

            //Първо трябва да напълним назъбения масив със стойностите, които ще ни подадат от конзолата.

            for (int row = 0; row < n; row++)
            {
                jaggedArray[row] = Console.ReadLine()
                    .Split(" ")
                    .Select(double.Parse)
                    .ToArray();
            }

            //Преди да добавяме или премахваме стойности, трябва да анализираме матрицата, и въз основа на началните стойности
            //да умножаваме или делим. Затова и назъбения масив трябва да е със стойности от тип double, а не int,
            //защото при делене се получава double число.

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                int currentRowLenght = jaggedArray[i].Length;
                int nextRowLenght = int.MinValue;

                if (i + 1 < jaggedArray.GetLength(0))
                {
                    nextRowLenght = jaggedArray[i + 1].Length;

                    if (currentRowLenght == nextRowLenght)
                    {
                        for (int j = 0; j < jaggedArray[i].Length; j++)
                        {
                            jaggedArray[i][j] *= 2;
                            jaggedArray[i + 1][j] *= 2;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < jaggedArray[i].Length; j++)
                        {
                            jaggedArray[i][j] /= 2;
                        }
                        for (int j = 0; j < jaggedArray[i + 1].Length; j++)
                        {
                            jaggedArray[i + 1][j] /= 2;
                        }
                    }
                }
            }

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0].ToLower() == "add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    double value = double.Parse(command[3]);

                    //При проверка за валидност трябва да се включи col >= 0 (тъй като може да е отрицателно число),
                    //и също row < jaggedArray.GetLength(0), а не row <= jaggedArray.GetLength(0) (при дължина 5,
                    //посления валиден индекс за row ще е 4, а не 5), същото и за проверката за col.

                    if (row >= 0 && row < jaggedArray.GetLength(0) && col < jaggedArray[row].Length && col >= 0)
                    {
                        jaggedArray[row][col] += value;
                    }

                }
                else if (command[0].ToLower() == "subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    double value = double.Parse(command[3]);

                    if (row >= 0 && row < jaggedArray.GetLength(0) && col < jaggedArray[row].Length && col >= 0)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }
    }
}
