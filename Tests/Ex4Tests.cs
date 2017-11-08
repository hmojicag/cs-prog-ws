using System;
using Xunit;
using Ex4;

namespace Tests
{
    public class Ex4Tests
    {
        [Fact]
        public void TestLargerNumber() {
            if (!Ex4.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex4");

            int larger = Ex4.Program.largerNumber(1,2,3);
            Assert.True(larger == 3, 
                "Expected larger number: 3\n" + 
                "Test Data: (1,2,3)\n" +
                "Your answer was: " +  larger);

            larger = Ex4.Program.largerNumber(-10,2,0);
            Assert.True(larger == 2, 
                "Expected larger number: 2\n" + 
                "Test Data: (-10,2,0)\n" +
                "Your answer was: " +  larger);

            larger = Ex4.Program.largerNumber(100,100,100);
            Assert.True(larger == 100, 
                "Expected larger number: 100\n" + 
                "Test Data: (100,100,100)\n" +
                "Your answer was: " +  larger);

            larger = Ex4.Program.largerNumber(-100,-100,-100);
            Assert.True(larger == -100, 
                "Expected larger number: -100\n" + 
                "Test Data: (-100,-100,-100)\n" +
                "Your answer was: " +  larger);

            larger = Ex4.Program.largerNumber(-100,100,0);
            Assert.True(larger == 100, 
                "Expected larger number: 100\n" + 
                "Test Data: (-100,100,0)\n" +
                "Your answer was: " +  larger);

            larger = Ex4.Program.largerNumber(int.MaxValue,int.MinValue,0);
            Assert.True(larger == int.MaxValue, 
                "Expected larger number: int.MaxValue\n" + 
                "Test Data: (int.MaxValue,int.MinValue,0)\n" +
                "Your answer was: " +  larger);
        }
    }
}
