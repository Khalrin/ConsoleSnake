using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Meal
    {
        public Position position = new Position(11,11);

        public bool isAlive = false;


        public void RandomizeMealPosition()
        {
            Random rnd = new Random();
            int randomX = rnd.Next(1, 27);
            int randomY = rnd.Next(1, 101);
            position.PositionX = randomX;
            position.PositionY = randomY;
        }

        public void drawMeal()
        {
            Console.Write("o");
            isAlive = true;
        }

        

    }
}
