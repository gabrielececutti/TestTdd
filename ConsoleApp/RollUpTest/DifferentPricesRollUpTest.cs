using RollUp.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollUpTest
{
    public class DifferentPricesRollUpTest
    {
        private IRollUpHandler _sut;
        public DifferentPricesRollUpTest()
        {
            _sut = new DifferentPriceRollUpHandler();
        }

        [Fact(Skip = "Not implemeted")]
        public void _4GTIN_2Variant_1Product_Test()
        {
            var data = new List<(string, string, string, int?)>
            {
            ("G1", "V1", "P1", 50),
            ("G2", "V1", "P1", 100),
            ("G3", "V2", "P1", 100),
            ("G4", "V2", "P1", 100)
            };

            var result = _sut.Calculate(data);
            var expected = new List<(string, int)> { ("P1", 50), ("V2", 50), ("G2", 100) };
            Assert.Equal(expected, result);
        }

    }
}
