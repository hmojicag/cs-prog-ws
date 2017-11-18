using System;
using Xunit;
using Ex8;

namespace Tests
{
    public class Ex8Tests
    {
        [Fact]
        public void TestSum2NWithNegatives() {
            if (!Ex8.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex8");

            int sum = Ex8.Program.sum2NWithNegatives(0);
            Assert.True(sum == 0,
            "Test Data: n=0 \n" +
            "Expected Output: 0 \n" +
            "Your output: " + sum);

            sum = Ex8.Program.sum2NWithNegatives(5);
            Assert.True(sum == 15,
            "Test Data: n=5 \n" +
            "Expected Output: 15 \n" +
            "Your output: " + sum);

            sum = Ex8.Program.sum2NWithNegatives(-5);
            Assert.True(sum == -15,
            "Test Data: n=-5 \n" +
            "Expected Output: -15 \n" +
            "Your output: " + sum);
        }
    }
}
