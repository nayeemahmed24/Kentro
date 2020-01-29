using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentro
{
    class PShuffle:IPowerUp
    {
        private int probability=10;
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
