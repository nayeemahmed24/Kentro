using System;

namespace Kentro
{
    class PShuffle:IPowerUp
    {
        private int probability=6;
        public int getProbability()
        {
            return probability;
        }

        public void Operation()
        {
            throw new NotImplementedException();
        }
    }
}
