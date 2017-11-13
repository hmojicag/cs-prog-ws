using System;
using Xunit;
using Ex2;

namespace Tests
{
    public class Ex2Tests
    {
        [Fact]
        public void TestGreetingsUser() {
            if (!Ex2.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex2");

            string greeting = Ex2.Program.GreetingsUser("Haza");
            string expected = "Greetings Haza";
            Assert.True(greeting.Equals(expected),
                "For User 'Haza' the greeting was: " + greeting +
                "\nExpected is: " + expected);
            
            greeting = Ex2.Program.GreetingsUser("");
            expected = "Greetings ";
            Assert.True(greeting.Equals(expected),
                "For User {An Empty String} the greeting was: " + greeting +
                "\nExpected is: " + expected);

            greeting = Ex2.Program.GreetingsUser(null);
            Assert.True(greeting.Equals("Greetings "),
                "For User {null} the greeting was: " + greeting +
                "\nExpected is: " + expected);
        }
    }
}
