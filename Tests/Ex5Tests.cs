using System;
using Xunit;
using Ex5;

namespace Tests
{
    public class Ex5Tests
    {
        [Fact]
        public void TestLargerNumber() {
            if (!Ex5.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex5");

            string noWhiteSpaces = Ex5.Program.SupressWhiteSpaces("Hello Joe Doe ");
            Assert.True(noWhiteSpaces.Equals("HelloJoeDoe"), 
                "Expected output: \"HelloJoeDoe\"\n" + 
                "Test Data: \"Hello Joe Doe \"\n" +
                "Your answer was: " +  noWhiteSpaces);
            
            noWhiteSpaces = Ex5.Program.SupressWhiteSpaces(null);
            Assert.NotNull(noWhiteSpaces);
            Assert.True(noWhiteSpaces.Equals(""), 
                "Expected output: \"\"\n" + 
                "Test Data: null\n" +
                "Your answer was: " +  noWhiteSpaces);
            
            noWhiteSpaces = Ex5.Program.SupressWhiteSpaces("");
            Assert.True(noWhiteSpaces.Equals(""), 
                "Expected output: \"\"\n" + 
                "Test Data: \"\"\n" +
                "Your answer was: " +  noWhiteSpaces);
            
            noWhiteSpaces = Ex5.Program.SupressWhiteSpaces("   ");
            Assert.True(noWhiteSpaces.Equals(""), 
                "Expected output: \"\"\n" + 
                "Test Data: \"   \"\n" +
                "Your answer was: " +  noWhiteSpaces);
            
            noWhiteSpaces = Ex5.Program.SupressWhiteSpaces(" --- ---- ");
            Assert.True(noWhiteSpaces.Equals("-------"), 
                "Expected output: \"-------\"\n" + 
                "Test Data: \" --- ---- \"\n" +
                "Your answer was: " +  noWhiteSpaces);
        }
    }
}
