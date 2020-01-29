using System;

namespace Kentro
{
    class PFreeze:IPowerUp
    {
        private int probability = 3;
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
