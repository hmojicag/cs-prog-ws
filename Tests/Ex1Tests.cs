using System;
using Xunit;
using Ex1;

namespace Tests
{
    public class Ex1Tests
    {
        [Fact]
        public void TestSumTwoNumbers() {
            if (!Ex1.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex1");

            var sum = Ex1.Program.sumTwoNumbers(2, 2);
            Assert.True(sum == 4, "2+2 should be 4");

            sum = Ex1.Program.sumTwoNumbers(-1, 1);
            Assert.True(sum == 0, "-1+1 should be 0");

            sum = Ex1.Program.sumTwoNumbers(0, 0);
            Assert.True(sum == 0, "0+0 should be 0");

            sum = Ex1.Program.sumTwoNumbers(int.MaxValue, 1);
            string assertMsg = int.MaxValue + "+" + 1;
            assertMsg += " should be " + int.MinValue;
            assertMsg += "\nThe Max Value of an integer is: " + int.MaxValue;
            assertMsg += "\nTherefore if you sum one to it, it will overflow";
            assertMsg += "up to the min value of: " + int.MinValue;
            Assert.True(sum == int.MinValue, assertMsg);
        }
    }
}
