

using System.Collections.Generic;

namespace Kentro
{
    class Grid
    {
        #region Variable
        public Dictionary<Position, Card> grid;
        public Position goal;
        public Player player1, player2;
        #endregion

        #region Constructor

        public Grid(int gridSize)
        {
            grid = new Dictionary<Position, Card>();
            goal.x = (gridSize - 1) / 2;
            goal.y = (gridSize - 1) / 2;
            player1 = new Player(0, 0,PlayerEnum.Player1);
            player2 = new Player(gridSize - 1, gridSize - 1,PlayerEnum.Player2);
        }


        #endregion

        public Card getCard(int x, int y, PlayerEnum playerid)
        {
            Position pos = new Position(x,y);
            if (grid.ContainsKey(pos))
            {
                return grid[pos];
            }
            else
            {
                Card card = new Card(playerid);
                grid.Add(pos,card);
                return card;
            }
        }



    }
}
