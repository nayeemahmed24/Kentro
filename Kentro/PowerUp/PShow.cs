using System;

namespace Kentro
{
    class PShow:IPowerUp
    {
        private int probability = 4;
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
