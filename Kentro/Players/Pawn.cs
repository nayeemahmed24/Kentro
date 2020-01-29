

namespace Kentro
{
    public class Pawn
    {
        public int x { get; set; }
        public int y { get; set; }
        public int Move { get; set; }

        public Pawn(int x,int y)
        {
            this.x = x;
            this.y = y;
            Move = 1;
        }



    }
}
