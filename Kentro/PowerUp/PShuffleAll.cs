using System;
using System.Collections.Generic;

namespace Kentro
{
    
     public class PShuffleAll:IPowerUp
    {
        private int probability = 7;
        public Card card;
        public int getProbability()
        {
            return probability;
        }

        public void Operation(Player player1, Player player2, Dictionary<Position, Card> grid, params object[] arguments)
        {
            grid.Clear();
            for (int i = 0; i < 3; i++)
            {
                grid.Add(player1.pawn[i].position, new Card(
                    player1.PlayerId,player1.pawn[i].Move));
            }
            

            for (int i = 0; i < 3; i++)
            {
                grid.Add(player2.pawn[i].position, new Card(
                    player2.PlayerId,player2.pawn[i].Move));
            }
        }

        
    }
}
