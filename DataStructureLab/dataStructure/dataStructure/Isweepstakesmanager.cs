using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    interface Isweepstakesmanager
    {
        void InsertSweepstakes(Sweepstake sweepstake);

        Sweepstake GetNextSweepstake();

    }
}
