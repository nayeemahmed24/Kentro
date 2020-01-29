
using System.Collections.Generic;


namespace Kentro
{
    public class Player
    {
        public List<IPowerUp> PowerUps;
        public List<Pawn> pawn;
        private int NumberOfPawn = 3;
        public Player(int x,int y)
        {
            pawn = new List<Pawn>();
            for(int i = 0; i<NumberOfPawn; i++)
                pawn.Add(new Pawn(x,y));
            PowerUps = new List<IPowerUp>();
        }


    }
}
