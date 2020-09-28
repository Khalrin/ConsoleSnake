using System;

namespace ConsoleSnake
{
    class Board
    {
        static public int sizeX { get; set; } = 28;
        static public int sizeY { get; set; } = 102;

        public static char[,] gameBoard = new char[sizeX, sizeY];

        public static void DrawStarterBoard(char borderChar)
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if ((i == 0 || j == 0) || (i == sizeX - 1 || j == sizeY - 1))
                        gameBoard[i, j] = borderChar;
                }
            }
        }

        public static void PrintBoard()
        {

            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    Console.Write(gameBoard[i, j]);
                }
                Console.WriteLine();
            }


        }
    }
}
