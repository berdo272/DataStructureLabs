using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class SweepstakeStackManager : Isweepstakesmanager
    {
        Stack<Sweepstake> SweepstakeStack;

        public SweepstakeStackManager()
        {
            SweepstakeStack = new Stack<Sweepstake>();
        }

        public Sweepstake GetNextSweepstake()
        {
            return SweepstakeStack.Pop();
        }

        public void InsertSweepstakes(Sweepstake sweepstake)
        {
            SweepstakeStack.Push(sweepstake);
        }
    }
}
