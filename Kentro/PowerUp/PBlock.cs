using System;

namespace Kentro
{
    class PBlock:IPowerUp
    {
        private int probability = 5;
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
