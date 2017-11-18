using System;
using Xunit;
using Ex12;

namespace Tests
{
    public class Ex12Tests
    {
        [Theory]
        [InlineData(
            new string[] {"a","b","c"},
            new string[] {"1","2","3"},
            new string[] {"a","1","b","2","c","3"}
        )]
        [InlineData(
            new string[0],
            new string[] {"1","2","3"},
            new string[] {"1","2","3"}
        )]
        [InlineData(
            new string[] {"a","b","c"},
            new string[0],
            new string[] {"a","b","c"}
        )]
        [InlineData(
            null,
            new string[] {"1","2","3"},
            new string[] {"1","2","3"}
        )]
        [InlineData(
            new string[] {"a","b","c"},
            null,
            new string[] {"a","b","c"}
        )]
        [InlineData(
            new string[] {"a","b","c","h","l","f","LOL","dw"},
            new string[] {"1","2","3","10","--","uij"},
            new string[] {"a","1","b","2","c","3","h","10","l","--","f","uij","LOL","dw"}
        )]
        public void TestArrayAlternated(string[] array1, string[] array2, string[] result) {
            if (!Ex12.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex12");

            string[] c = Ex12.Program.arrayAlternated(array1, array2);
            Assert.NotNull(c);
            Assert.True(TestUtils.areEqualArrays(c,result),
            "Test Data: array1 " + TestUtils.array2String(array1) + ", array2 " + TestUtils.array2String(array2) + "\n" +
            "Expected Output: " + TestUtils.array2String(result) + "\n" +
            "Your output: " + TestUtils.array2String(c));
        }

    }
}
