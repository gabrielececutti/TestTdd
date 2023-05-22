using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollUp.Chain
{
    public class BaseRollUpHandler : AbstractRollUpHandler
    {
        public override List<(string, int)> Calculate(List<(string, string, string, int?)> inputs)
        {
            var output = new List<(string, int)>();
            var result = inputs
                .GroupBy(d => (d.Item2, d.Item3))
                .Select(group =>
                {
                    var lowestPrice = group.Min(d => d.Item4);
                    var prices = group.Where(d => d.Item4 == lowestPrice).Select(d => d.Item4).ToList();
                    return (group.Key.Item2, lowestPrice, prices);
                })
                .ToList();
            foreach (var item in result) output.Add(((string, int))(item.Item1, item.Item2));
            return output.Distinct().ToList();
        }
    }
}
