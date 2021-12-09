using FindingSumOfString;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TextServiceTests
{
    public class UnitTest1
    {
        [Fact]
        public void SumOfString_CheckSum()
        {
            string testString = "123, 123, 123.5, 123";
            var actual = TextService.SumOfString(testString);
            Assert.Equal(492.5, actual);
        }

        [Fact]
        public void SumOfString_CheckNull()
        {
            string testString = null;
            var actual = TextService.SumOfString(testString);
            Assert.Equal(float.NaN, actual);
        }

        [Fact]
        public void FindMaxValue()
        {
            List<string> lf = new();
            lf.Add("2343, 234, 2342, 42342, 34234, 24");
            lf.Add("234,234,24234.2432,234234,234324,234234,2432");
            lf.Add("7,7,7,7,7,7,7,7,7,7,7,7");
            var actual = lf.SumEveryString().MaxValue();
            Assert.Equal(2, actual);
        }

        [Fact]
        public void FindMaxValueWithBrokenString()
        {
            List<string> lf = new();
            lf.Add("7,7,7,7,7,7,7,7,7,7,7,7");
            lf.Add("234,234,242342@`432,234234,234..324,234234,2432");
            lf.Add("2343, 234, 2342, 42342, 34234, 24");
            var actual = lf.SumEveryString().MaxValue();
            Assert.Equal(3, actual);
        }

        [Fact]
        public void FindBrokenSymbolsInCollection_CheckNumberBrolenString()
        {
            List<string> lf = new();
            lf.Add("7,7,7,7,7,7,7,7,7,7,7,7");
            lf.Add("234,234,242342@`4qwee32,234234,234..324,234234,2432");
            lf.Add("2343, 234, 2342, 42342, 34234, 24");
            var actual = lf.SumEveryString().BrokenSymbolsInCollection().First();
            Assert.Equal(2, actual);
        }

        [Fact]
        public void NullCheck_FindMaxInCollection()
        {
            List<string> lf = new();
            var actual = lf.SumEveryString().MaxValue();
            Assert.Equal(0, actual);
        }
    }
}
