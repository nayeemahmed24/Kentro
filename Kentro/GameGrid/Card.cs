

using System;

namespace Kentro
{
    class Card
    {
        public int value;
        public bool flipped;
        public IPowerUp powerup;
        private PowerUpFactory powerFactory;
        public Card()
        {
            value = new Random().Next(1,6);
            flipped = true;
            powerFactory = new PowerUpFactory();
            if (powerFactory.ListPowerUps.Count == 0)
            {
                powerup = new PNone();
            }
            else
            {

                powerup = powerFactory.ListPowerUps.Peek();
                powerFactory.ListPowerUps.Pop();


            }

        }
    }
}
