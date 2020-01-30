using System;
using System.Collections.Generic;

namespace Kentro
{
    public class PBlock:IPowerUp
    {
        private int probability = 5;

        public int getProbability()
        {
            throw new NotImplementedException();
        }

        public void Operation(Player player1, Player player2, Dictionary<Position, Card> grid, params object[] arguments)
        {
            throw new NotImplementedException();
        }
    }
}
