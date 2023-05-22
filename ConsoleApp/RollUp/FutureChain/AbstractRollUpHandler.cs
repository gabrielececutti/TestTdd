using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollUp.Chain
{
    public abstract class AbstractRollUpHandler : IRollUpHandler
    {
        protected IRollUpHandler _successor;
        public abstract List<(string,int)> Calculate(List<(string, string, string, int?)> inputs);

        public void SetSuccessor(IRollUpHandler rollUpHandler)
        {
            _successor.SetSuccessor(rollUpHandler);
        }
    }
}
