using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Position
    {
        public Position() { }
    

        public Position(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }

        public int PositionX { get; set; } = 2;
        public int PositionY { get; set; } = 2;




    }
}
