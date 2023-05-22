using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollUp.Chain
{
    public class NullableRollUpHandler : AbstractRollUpHandler
    {
        public override List<(string, int)> Calculate(List<(string, string, string, int?)> inputs)
        {
            return null;
        }
    }
}
