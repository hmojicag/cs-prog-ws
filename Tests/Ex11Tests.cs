using System;
using Xunit;
using Ex11;

namespace Tests
{
    public class Ex11Tests
    {
        [Theory]
        [InlineData(
            new string[] {"Hello","World"},
            new string[] {"Hola","Mundo","FIME"},
            new string[] {"Hello","World","Hola","Mundo","FIME"}
        )]
        [InlineData(
            new string[] {"Hello","World"},
            new string[0],
            new string[] {"Hello","World"}
        )]
        [InlineData(
            new string[0],
            new string[] {"Hola","Mundo","FIME"},
            new string[] {"Hola","Mundo","FIME"}
        )]
        [InlineData(
            null,
            new string[] {"Hola","Mundo","FIME"},
            new string[] {"Hola","Mundo","FIME"}
        )]
        [InlineData(
            new string[] {"Hello","World"},
            null,
            new string[] {"Hello","World"}
        )]
        [InlineData(
            new string[] {"Hello","World","","LOL"},
            new string[] {"Hola","Mundo","FIME","1","100","50",":D",":|",":)",":$"},
            new string[] {"Hello","World","","LOL","Hola","Mundo","FIME","1","100","50",":D",":|",":)",":$"}
        )]
        public void TestArrayConcatenation(string[] array1, string[] array2, string[] result) {
            if (!Ex11.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex11");

            string[] c = Ex11.Program.arrayConcatenation(array1, array2);
            Assert.NotNull(c);
            Assert.True(TestUtils.areEqualArrays(c,result),
            "Test Data: array1 " + TestUtils.array2String(array1) + ", array2 " + TestUtils.array2String(array2) + "\n" +
            "Expected Output: " + TestUtils.array2String(result) + "\n" +
            "Your output: " + TestUtils.array2String(c));
        }

    }
}
