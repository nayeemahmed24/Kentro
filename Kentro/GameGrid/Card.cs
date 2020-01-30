

using System;

namespace Kentro
{
    public class Card
    {
        public int value;
        public bool flipped;
        public IPowerUp powerup;
        /// <summary>
        /// Use enum to specify whose pawn it is... 
        /// </summary>
        private PowerUpFactory powerFactory;

        public Card()
        {
            value = new Random().Next(1,7);//
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
