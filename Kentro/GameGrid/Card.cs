﻿

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

        public Card(Player player)
        {

            value = new Random().Next(1,7);  
            flipped = true;
            powerFactory = new PowerUpFactory();

            switch (powerFactory.ListPowerUps.Count)
            {
                case 0:
                    powerup = new PNone();
                    break;
                default:
                    powerup = powerFactory.ListPowerUps.Peek();
                    player.PowerUps.Add(powerup);
                    powerFactory.ListPowerUps.Pop();
                    break;
            }

        }

        public Card(PlayerEnum player, int value)
        {
            this.value = value;
            pawnOwner = player;
            flipped = true;
            powerup = new PNone();
        }
    }
}
