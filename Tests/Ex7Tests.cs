using System;
using Xunit;
using Ex7;

namespace Tests
{
    public class Ex7Tests
    {
        [Fact]
        public void TestSum2N() {
            if (!Ex7.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex7");

            int sum = Ex7.Program.sum2N(0);
            Assert.True(sum == 0,
            "Test Data: n=0 \n" +
            "Expected Output: 0 \n" +
            "Your output: " + sum);

            sum = Ex7.Program.sum2N(5);
            Assert.True(sum == 15,
            "Test Data: n=5 \n" +
            "Expected Output: 15 \n" +
            "Your output: " + sum);
        }
    }
}
