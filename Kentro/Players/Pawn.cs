﻿

namespace Kentro
{
    public class Pawn
    {
        public Position position { get; set; }
        public int Move { get; set; }

        public Pawn(int x,int y)
        {
            position = new Position(x,y);
            Move = 1;
        }

    }
}
