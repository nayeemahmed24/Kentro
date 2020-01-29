using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentro.Players
{
    public class Player
    {
        public List<IPowerUp> powerUps;
        public List<Pawn> pawn;
        private int NumberOfPawn = 3;
        public Player()
        {
            pawn = new List<Pawn>();
            for(int i = 0; i<NumberOfPawn; i++)
                pawn.Add(new Pawn());
            powerUps = new List<IPowerUp>();
        }


    }
}
