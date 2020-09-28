using System.Collections;
using System.Data;
using System;

namespace ConsoleSnake
{
    class Snake
    {
        public enum Direction {UP,DOWN,LEFT,RIGHT};

        public Direction MoveDirection { get; set; } = Direction.RIGHT;

        public int Speed { get; set; }
        public int Length { get; set; } = 0;
        public  int PositionX { get; set; } = 1;
        public int PositionY { get; set; } = 1;
        public  char SnakeTailChar { get; set; } = '=';
        public  char SnakeHeadChar { get; set; } = '@';


        public void Eat()
        {
            Length++;
        }

        public void Move()
        {
            switch (MoveDirection)
            {
                case Direction.UP:
                    PositionX--;
                    break;
                case Direction.DOWN:
                    PositionX++;
                    break;
                case Direction.RIGHT:
                    PositionY++;
                    break;
                case Direction.LEFT:
                    PositionY--;
                    break;

            }

            Console.SetCursorPosition(PositionY, PositionX);
            Console.Write(SnakeHeadChar);

        }




    }
}
