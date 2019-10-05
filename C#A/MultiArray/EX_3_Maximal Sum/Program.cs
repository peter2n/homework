//namespace EX_3_Maximal_Sum
using System;
using System.Linq;

namespace EX_3_Maximal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] matrixDimensions = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixDimensions[0], matrixDimensions[1]];

            int squareSize = 3; // it can be different number



            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int maxSum = int.MinValue;
            int upperLeftRow = -1;
            int leftColumn = -1;

            for (int row = 0; row < matrix.GetLength(0) - squareSize + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - squareSize + 1; col++)
                {
                    int currentSum = MaxSum(row, col, squareSize, matrix);

                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        upperLeftRow = row;
                        leftColumn = col;
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);

            for (int row = upperLeftRow; row < upperLeftRow + squareSize; row++)
            {
                for (int col = leftColumn; col < leftColumn + squareSize; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        static int MaxSum(int row, int col, int size, int[,] matrix)
        {
            int sum = 0;
            int rows = row + size;
            int cols = col + size;
            for (int r = row; r < rows; r++)
            {
                for (int c = col; c < cols; c++)
                {
                    sum += matrix[r, c];
                }
            }
            return sum;
        }
    }
}
