using System;
using Xunit;
using Ex9;

namespace Tests
{
    public class ExTests
    {
        [Fact]
        public void TestIsPrime() {
            if (!Ex9.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex9");

            bool isPrime = Ex9.Program.isPrime(-1);
            Assert.False(isPrime,
            "Test Data: number = -1 \n" +
            "Expected Output: false \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(0);
            Assert.False(isPrime,
            "Test Data: number = 0 \n" +
            "Expected Output: false \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(1);
            Assert.False(isPrime,
            "Test Data: number = 1 \n" +
            "Expected Output: false \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(2);
            Assert.True(isPrime,
            "Test Data: number = 2 \n" +
            "Expected Output: true \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(11);
            Assert.True(isPrime,
            "Test Data: number = 11 \n" +
            "Expected Output: true \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(37);
            Assert.True(isPrime,
            "Test Data: number = 37 \n" +
            "Expected Output: true \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(89);
            Assert.True(isPrime,
            "Test Data: number = 89 \n" +
            "Expected Output: true \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(173);
            Assert.True(isPrime,
            "Test Data: number = 173 \n" +
            "Expected Output: true \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(193);
            Assert.True(isPrime,
            "Test Data: number = 193 \n" +
            "Expected Output: true \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(111);
            Assert.False(isPrime,
            "Test Data: number = 111 \n" +
            "Expected Output: false \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(122);
            Assert.False(isPrime,
            "Test Data: number = 122 \n" +
            "Expected Output: false \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(40);
            Assert.False(isPrime,
            "Test Data: number = 40 \n" +
            "Expected Output: false \n" +
            "Your output: " + isPrime);

            isPrime = Ex9.Program.isPrime(6);
            Assert.False(isPrime,
            "Test Data: number = 6 \n" +
            "Expected Output: false \n" +
            "Your output: " + isPrime);
        }
    }
}
