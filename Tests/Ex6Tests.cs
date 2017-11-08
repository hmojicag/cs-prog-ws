using System;
using Xunit;
using Ex6;

namespace Tests
{
    public class Ex6Tests
    {
        [Fact]
        public void TestLargerNumber() {
            if (!Ex6.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex6");

            double result = Ex6.Program.Calculate(100, 2, "+");
            Assert.True(result == 102, 
                "Expected output: 102\n" + 
                "Test Data: (100, 2, \"+\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, "*");
            Assert.True(result == 200, 
                "Expected output: 200\n" + 
                "Test Data: (100, 2, \"*\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, "-");
            Assert.True(result == 98, 
                "Expected output: 98\n" + 
                "Test Data: (100, 2, \"-\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, "^");
            Assert.True(result == 10000, 
                "Expected output: 10000\n" + 
                "Test Data: (100, 2, \"^\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, "/");
            Assert.True(result == 50, 
                "Expected output: 50\n" + 
                "Test Data: (100, 2, \"/\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 0, "/");
            Assert.True(result == 0.0, 
                "Expected output: 0.0\n" + 
                "Test Data: (100, 0, \"/\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, null);
            Assert.True(result == 0.0, 
                "Expected output: 0.0\n" + 
                "Test Data: (100, 2, null)\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(-100, -2, "-");
            Assert.True(result == -98, 
                "Expected output: -98\n" + 
                "Test Data: (-100, -2, \"-\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, "");
            Assert.True(result == 0.0, 
                "Expected output: 0.0\n" + 
                "Test Data: (100, 2, \"\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, " ");
            Assert.True(result == 0.0, 
                "Expected output: 0.0\n" + 
                "Test Data: (100, 2, \" \")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, "a");
            Assert.True(result == 0.0, 
                "Expected output: 0.0\n" + 
                "Test Data: (100, 2, \"a\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(0, 2, "/");
            Assert.True(result == 0.0, 
                "Expected output: 0.0\n" + 
                "Test Data: (0, 2, \"/\")\n" +
                "Your answer was: " +  result);

            // Test Trimming
            result = Ex6.Program.Calculate(100, 2, " + ");
            Assert.True(result == 102, 
                "Expected output: 102\n" + 
                "Test Data: (100, 2, \" + \")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, "  *  ");
            Assert.True(result == 200, 
                "Expected output: 200\n" + 
                "Test Data: (100, 2, \"  *  \")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, " - ");
            Assert.True(result == 98, 
                "Expected output: 98\n" + 
                "Test Data: (100, 2, \" - \")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, "  ^ ");
            Assert.True(result == 10000, 
                "Expected output: 10000\n" + 
                "Test Data: (100, 2, \"  ^ \")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, " /  ");
            Assert.True(result == 50, 
                "Expected output: 50\n" + 
                "Test Data: (100, 2, \" /  \")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 0, "  /   ");
            Assert.True(result == 0.0, 
                "Expected output: 0.0\n" + 
                "Test Data: (100, 0, \"  /   \")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(-100, -2, "    -");
            Assert.True(result == -98, 
                "Expected output: -98\n" + 
                "Test Data: (-100, -2, \"    -\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(100, 2, " a");
            Assert.True(result == 0.0, 
                "Expected output: 0.0\n" + 
                "Test Data: (100, 2, \" a\")\n" +
                "Your answer was: " +  result);
            
            result = Ex6.Program.Calculate(0, 2, "       / ");
            Assert.True(result == 0.0, 
                "Expected output: 0.0\n" + 
                "Test Data: (0, 2, \"       / \")\n" +
                "Your answer was: " +  result);
        }
    }
}
