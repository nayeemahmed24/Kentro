﻿

namespace Kentro
{
    public class Pawn
    {
        public Position position;
        public int Move { get; set; }

        public Pawn(int x,int y)
        {
            position.x = x;
            position.y = y;
            Move = 1;
        }



    }
}
