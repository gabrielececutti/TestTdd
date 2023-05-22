using ConsoleApp.IOC;
using Microsoft.Extensions.DependencyInjection;
using RollUp.Chain;

namespace RollUpTest
{
    public class BaseRoolUpTest
    {
        private IRollUpHandler _sut;
        public BaseRoolUpTest() 
        {
            _sut = new BaseRollUpHandler();
        }

        [Fact]
        public void  _4GTIN_2Variant_1Product_Test()
        {
            var data = new List<(string, string, string, int?)>
            {
            ("G1", "V1", "P1", 100),
            ("G2", "V1", "P1", 100),
            ("G3", "V2", "P1", 100),
            ("G4", "V2", "P1", 100)
            };
            var result = _sut.Calculate(data);
            var expected = new List<(string, int)> { ("P1", 100) };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void _5GTIN_2Variant_1Product_Test()
        {
            var data = new List<(string, string, string, int?)>
            {
            ("G1", "V1", "P1", 100),
            ("G2", "V1", "P1", 100),
            ("G3", "V2", "P1", 100),
            ("G4", "V2", "P1", 100),
            ("G5", "V2", "P1", 100)
            };
            var result = _sut.Calculate(data);
            var expected = new List<(string, int)> { ("P1", 100) };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void _5GTIN_3Variant_1Product_Test()
        {
            var data = new List<(string, string, string, int?)>
            {
            ("G1", "V1", "P1", 100),
            ("G2", "V1", "P1", 100),
            ("G3", "V2", "P1", 100),
            ("G4", "V2", "P1", 100),
            ("G5", "V3", "P1", 100)
            };
            var result = _sut.Calculate(data);
            var expected = new List<(string, int)> { ("P1", 100) };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void _5GTIN_3Variant_2Product_Test()
        {
            var data = new List<(string, string, string, int?)>
            {
            ("G1", "V1", "P1", 100),
            ("G2", "V1", "P1", 100),
            ("G3", "V2", "P1", 100),
            ("G4", "V2", "P1", 100),
            ("G5", "V3", "P2", 100)
            };
            var result = _sut.Calculate(data);
            var expected = new List<(string, int)> { ("P1", 100), ("P2", 100)};
            Assert.Equal(expected, result);
        }
    }
}