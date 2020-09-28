using System;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Board.DrawStarterBoard('*');
            Board.PrintBoard();

            bool exit = false;
            double frameRate = 1000 / 5;
            DateTime previousDate = DateTime.Now;

            while (!exit)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey(true);

                    switch (input.Key)
                    {
                        case ConsoleKey.Escape:
                            exit = true;
                            break;

                        case ConsoleKey.UpArrow:
                            snake.MoveDirection = Snake.Direction.UP;
                            break;

                        case ConsoleKey.DownArrow:
                            snake.MoveDirection = Snake.Direction.DOWN;
                            break;

                        case ConsoleKey.RightArrow:
                            snake.MoveDirection = Snake.Direction.RIGHT;
                            break;

                        case ConsoleKey.LeftArrow:
                            snake.MoveDirection = Snake.Direction.LEFT;
                            break;
                    }
                    
                }

                if((DateTime.Now - previousDate).TotalMilliseconds >= frameRate)
                {
                    snake.Move();
                    previousDate = DateTime.Now;
                }
             
            }



        }
    }
}
