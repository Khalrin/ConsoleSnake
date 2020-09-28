using System;
using System.Linq;
using System.Security.Policy;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Snake snake = new Snake();
            Meal meal = new Meal();
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
                            snake.SnakeHeadChar = '^';
                            break;

                        case ConsoleKey.DownArrow:
                            snake.MoveDirection = Snake.Direction.DOWN;
                            snake.SnakeHeadChar = 'v';
                            break;

                        case ConsoleKey.RightArrow:
                            snake.MoveDirection = Snake.Direction.RIGHT;
                            snake.SnakeHeadChar = '>';
                            break;

                        case ConsoleKey.LeftArrow:
                            snake.MoveDirection = Snake.Direction.LEFT;
                            snake.SnakeHeadChar = '<';
                            break;
                    }
                    
                }

                if((DateTime.Now - previousDate).TotalMilliseconds >= frameRate)
                {
                    try
                    {

                        snake.Move();
                        exit = snake.GameOver();
                        snake.AddTailPositionToList();           
                        if(snake.TailPos.Count > snake.Length)
                        {
                            var endOfTail = snake.TailPos.First();
                            Console.SetCursorPosition(endOfTail.PositionY,endOfTail.PositionX);
                            Console.Write(" ");
                            snake.TailPos.Remove(endOfTail);
                        }
                    }
                    catch(ArgumentOutOfRangeException e)
                    { 
                        exit = true;
                    }
                    previousDate = DateTime.Now;

                    if (snake.HeadPosition.PositionX == meal.position.PositionX && snake.HeadPosition.PositionY == meal.position.PositionY)
                    {
                        meal.isAlive = false;
                        snake.Eat();
                        frameRate -=10;
                    }
                    if (!meal.isAlive)
                    {
                        meal.RandomizeMealPosition();
                        Console.SetCursorPosition(meal.position.PositionY, meal.position.PositionX);
                        meal.drawMeal();
                    }
                }            

            }
           



        }

    }
}
