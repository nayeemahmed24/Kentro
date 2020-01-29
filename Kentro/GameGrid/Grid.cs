

using System.Collections.Generic;

namespace Kentro
{
    class Grid
    {
        public Dictionary<KeyValuePair<int, int>, Card> grid;
        public Position goal;
        public Player player1, player2;

        public Grid(int gridSize)
        {
            grid = new Dictionary<KeyValuePair<int, int>, Card>();
            goal.x = (gridSize - 1) / 2;
            goal.y = (gridSize - 1) / 2;
            player1 = new Player(0,0);
            player2 = new Player(gridSize - 1,gridSize - 1);
        }

        public Card getCard(int x, int y)
        {
            return new Card();
        }
    }
}
