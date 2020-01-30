

using System;

namespace Kentro
{
    public class Card
    {
        public int value;
        public bool flipped;
        public IPowerUp powerup;
        public PlayerEnum pawnOwner;
        private PowerUpFactory powerFactory;

        public Card(PlayerEnum playerid)
        {
            pawnOwner = playerid;  
            value = new Random().Next(0,7);//
            flipped = true;
            powerFactory = new PowerUpFactory();
            switch (powerFactory.ListPowerUps.Count)
            {
                case 0:
                    powerup = new PNone();
                    break;
                default:
                    powerup = powerFactory.ListPowerUps.Peek();
                    powerFactory.ListPowerUps.Pop();
                    break;
            }

        }
    }
}
