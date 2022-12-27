using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeBusines
{
    abstract class Bee: IWorker
    {
        // стоимотсть (per) - за- смену
        public abstract float CostPerShift { get; } 
        public string Job { get; private set; }
        public Bee(string job)
        {
            Job = job;
        }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }
        protected virtual void DoJob () { /* the subclass overrides */ }
    }
}
