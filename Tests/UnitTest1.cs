using System;
using Xunit;
using Ex1;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = new ArithMeticOperations();
            var res = a.sum(2, 2);
            Assert.True(res == 4, "2+2 should be 4");
        }
    }
}
