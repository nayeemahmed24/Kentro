using System;

namespace Kentro
{
    class PChangeNumber:IPowerUp
    {
        private int probability = 2;
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
