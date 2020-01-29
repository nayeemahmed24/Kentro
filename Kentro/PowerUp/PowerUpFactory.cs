using System;
using System.Collections.Generic;


namespace Kentro
{
    public class PowerUpFactory
    {
        private Dictionary<IPowerUp,int> dic;
        private Dictionary<int, IPowerUp> track;
        private IPowerUp pBlock,pChangeNumber,pFreeze,pNone,pShow,pShuffle,pShuffleAll;
        public List<IPowerUp> ListPowerUps;
        public PowerUpFactory()
        {
            assign();
            ListPowerUps = new List<IPowerUp>();
        }

        public void GetPowerUp()
        {
            Random random = new Random();
            int RandomValue = random.Next(7);

            if (dic[track[RandomValue]] != 0)
            {
                dic[track[RandomValue]] -= 1;
                ListPowerUps.Add(track[RandomValue]);
            }
            else
            {
                ListPowerUps.Add(new PNone());
            }

        }


        public void assign()
        {
            pBlock = new PBlock();
            pChangeNumber = new PChangeNumber();
            pFreeze = new PFreeze();
            pNone = new PNone();
            pShow = new PShow();
            pShuffle = new PShuffle();
            pShuffleAll = new PShuffle();
            dic.Add(pBlock, 2);
            dic.Add(pChangeNumber, 2);
            dic.Add(pFreeze, 2);
            dic.Add(pNone, 2);
            dic.Add(pShow, 2);
            dic.Add(pShuffle, 2);
            dic.Add(pShuffleAll, 2);

            track.Add(pBlock.getProbability(), pBlock);
            track.Add(pChangeNumber.getProbability(), pBlock);
            track.Add(pFreeze.getProbability(), pBlock);
            track.Add(pNone.getProbability(), pBlock);
            track.Add(pShow.getProbability(), pBlock);
            track.Add(pShuffle.getProbability(), pBlock);
            track.Add(pShuffleAll.getProbability(), pBlock);

        }



    }
}
