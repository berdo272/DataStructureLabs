using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class SweepstakeQueueManager : Isweepstakesmanager
    {
        Queue<Sweepstake> SweepstakeQueue;

        public SweepstakeQueueManager()
        {
            SweepstakeQueue = new Queue<Sweepstake>();
        }

        public Sweepstake GetNextSweepstake()
        {
            return SweepstakeQueue.Dequeue();
        }

        public void InsertSweepstakes(Sweepstake sweepstake)
        {
            SweepstakeQueue.Enqueue(sweepstake);
        }
    }
}
