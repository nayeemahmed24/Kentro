using System;

namespace Kentro
{
    class PNone:IPowerUp
    {
        private int probability = 1;
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
