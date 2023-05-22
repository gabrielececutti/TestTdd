using RollUp.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollUpTest
{
    public class NullableRollUpTestcs
    {
        protected IRollUpHandler _sut;
        public NullableRollUpTestcs()
        {
            _sut = new NullableRollUpHandler();
        }

        [Fact]
        public void NullableTest()
        {
            var data = new List<(string, string, string, int?)>
            {
            ("G1", "V1", "P1", null),
            ("G2", "V1", "P1", 100),
            ("G3", "V2", "P1", 100),
            ("G4", "V2", "P1", 100),
            };
            var result = _sut.Calculate(data);
            var expected = new List<(string, int)> { ("G2", 100), ("V2", 100) };
            Assert.Equal(expected, result);
        }
    }
}
