using FindingSumOfString;
using System;
using System.Collections.Generic;
using Xunit;

namespace TextServiceTests
{
    public class UnitTest1
    {
        [Fact]
        public void FindMaxValue()
        {
            List<string> lf = new();
            lf.Add("2343, 234, 2342, 42342, 34234, 24");
            lf.Add("234,234,242342432,234234,234324,234234,2432");
            lf.Add("7,7,7,7,7,7,7,7,7,7,7,7");

            var actual = lf.SumEveryString().FindMaxIndexInCollection();
            Assert.Equal(2, actual);
        }
    }
}
