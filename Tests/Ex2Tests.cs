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
            Assert.True(greeting.Equals("Greetings Haza"),
                "For User Haza the greeting was: " + greeting);
            
            greeting = Ex2.Program.GreetingsUser("");
            Assert.True(greeting.Equals("Greetings "),
                "For User 'Empty String' the greeting was: " + greeting);

            greeting = Ex2.Program.GreetingsUser(null);
            Assert.True(greeting.Equals("Greetings "),
                "For User 'null' the greeting was: " + greeting);
        }
    }
}
