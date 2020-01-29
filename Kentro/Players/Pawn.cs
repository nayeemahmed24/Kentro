using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentro.Players
{
    public class Pawn
    {
        public int x { get; set; }
        public int y { get; set; }
        public int move { get; set; }

        public Pawn()
        {
            this.x = 0;
            this.y = 0;
            move = 1;
        }



    }
}
