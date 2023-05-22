using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollUp.Chain
{
    public interface IRollUpHandler
    {
        public List<(string, int)> Calculate(List<(string, string, string, int?)> inputs);
        public void SetSuccessor(IRollUpHandler rollUpHandler);
    }
}
