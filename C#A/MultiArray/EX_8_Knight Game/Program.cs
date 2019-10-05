//namespace EX_8_Knight_Game

using System;
using System.Linq;

namespace EX_8_Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var chessBoard = new char[size, size];

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                var data = Console.ReadLine().ToCharArray();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = data[col];
                }
            }

            var removedKnights = 0;

            var attackedRow = 0;
            var attackedCol = 0;

            while (true)
            {
                var maxAttacks = 0;
                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        var attack = 0;
                        if (chessBoard[row, col] == 'K')
                        {

                            //-2,+1
                            if (IsValid(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                attack++;
                            }
                            //- 2,-1
                            if (IsValid(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                attack++;
                            }
                            //- 1,+2
                            if (IsValid(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                attack++;
                            }
                            //- 1,-2
                            if (IsValid(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                attack++;
                            }
                            //+ 1,-2
                            if (IsValid(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                attack++;
                            }
                            //+ 1,+2
                            if (IsValid(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                attack++;
                            }
                            //+ 2,-1
                            if (IsValid(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                attack++;
                            }
                            //+ 2,+1
                            if (IsValid(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                attack++;
                            }

                            if (attack > maxAttacks)
                            {
                                maxAttacks = attack;
                                attackedRow = row;
                                attackedCol = col;
                            }
                        }

                    }

                }

                if (maxAttacks > 0)
                {
                    chessBoard[attackedRow, attackedCol] = '0';
                    removedKnights++;

                }
                else
                {
                    Console.WriteLine(removedKnights);
                    break;
                }

            }

        }

        private static bool IsValid(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) &&
                col >= 0 && col < chessBoard.GetLength(1);
        }
    }
}

