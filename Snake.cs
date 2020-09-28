using System.Collections;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleSnake
{
    class Snake
    {

        public enum Direction {UP,DOWN,LEFT,RIGHT};
        public Direction MoveDirection { get; set; } = Direction.RIGHT;

        public Position HeadPosition = new Position();

        public int Speed { get; set; }
        public int Length { get; set; } = 2;
        public  char SnakeTailChar { get; set; } = '=';
        public  char SnakeHeadChar { get; set; } = '>';

        public List<Position> TailPos = new List<Position>();

        public void Eat()
        {
            Length++;
        }

        public void Move()
        {
            switch (MoveDirection)
            {
                case Direction.UP:
                    HeadPosition.PositionX--;
                    break;
                case Direction.DOWN:
                    HeadPosition.PositionX++;
                    break;
                case Direction.RIGHT:
                    HeadPosition.PositionY++;
                    break;
                case Direction.LEFT:
                    HeadPosition.PositionY--;
                    break;

            }

            Console.SetCursorPosition(HeadPosition.PositionY, HeadPosition.PositionX);
            Console.Write(SnakeHeadChar);

        }
      
        public bool GameOver()
        {
            if (TailPos.Any(tail => tail.PositionX == HeadPosition.PositionX && tail.PositionY == HeadPosition.PositionY))
            {
                return true;
            }
            return false;
        }

        public void AddTailPositionToList()
        {
            Position someNewPosition = new Position();
            someNewPosition.PositionX = this.HeadPosition.PositionX;
            someNewPosition.PositionY = this.HeadPosition.PositionY;
            TailPos.Add(someNewPosition);
        }


    }
}
