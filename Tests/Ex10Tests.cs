using System;
using Xunit;
using Ex10;

namespace Tests
{
    public class Ex10Tests
    {
        [Fact]
        public void TestFindFirstPrimeNumbers() {
            if (!Ex10.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex10");

            string primes = Ex10.Program.findFirstPrimeNumbers(3);
            Assert.NotNull(primes);
            Assert.True(primes.Equals("2,3,5"),
            "Test Data: n=3 \n" +
            "Expected Output: \"2,3,5\" \n" +
            "Your output: \"" + primes + "\"");

            primes = Ex10.Program.findFirstPrimeNumbers(0);
            Assert.NotNull(primes);
            Assert.True(primes.Equals(""),
            "Test Data: n=0 \n" +
            "Expected Output: \"\" \n" +
            "Your output: \"" + primes + "\"");

            primes = Ex10.Program.findFirstPrimeNumbers(-3);
            Assert.NotNull(primes);
            Assert.True(primes.Equals(""),
            "Test Data: n=-3 \n" +
            "Expected Output: \"\" \n" +
            "Your output: \"" + primes + "\"");

            primes = Ex10.Program.findFirstPrimeNumbers(1);
            Assert.NotNull(primes);
            Assert.True(primes.Equals("2"),
            "Test Data: n=1 \n" +
            "Expected Output: \"2\" \n" +
            "Your output: \"" + primes + "\"");

            primes = Ex10.Program.findFirstPrimeNumbers(10);
            Assert.NotNull(primes);
            Assert.True(primes.Equals("2,3,5,7,11,13,17,19,23,29"),
            "Test Data: n=10 \n" +
            "Expected Output: \"2,3,5,7,11,13,17,19,23,29\" \n" +
            "Your output: \"" + primes + "\"");

            primes = Ex10.Program.findFirstPrimeNumbers(50);
            Assert.NotNull(primes);
            Assert.True(primes.Equals("2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97,101,103,107,109,113,127,131,137,139,149,151,157,163,167,173,179,181,191,193,197,199,211,223,227,229"),
            "Test Data: n=50 \n" +
            "Expected Output: \"2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97,101,103,107,109,113,127,131,137,139,149,151,157,163,167,173,179,181,191,193,197,199,211,223,227,229\" \n" +
            "Your output: \"" + primes + "\"");

        }
    }
}
