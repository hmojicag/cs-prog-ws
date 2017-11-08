using System;
using Xunit;
using Ex3;

namespace Tests
{
    public class Ex3Tests
    {
        [Fact]
        public void TestTriangleArea() {
            if (!Ex3.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex3");

            double area = Ex3.Program.triangleArea(1.0,1.0,1.0);
            Assert.True(area == 1.5,
                "The area of a triangle of 1.0,1.0,1.0 is 1.5 " +
                "Your answer was: " + area);

            area = Ex3.Program.triangleArea(2.0,2.0,2.0);
            Assert.True(area == 3.0,
                "The area of a triangle of 2.0,2.0,2.0 is 3.0 " +
                "Your answer was: " + area);

            area = Ex3.Program.triangleArea(0.0,2.0,2.0);
            Assert.True(area == -1.0,
                "If at least one side of the triangle is not valid " +
                "the return value should be -1.\n" +
                "Test Data: (0.0,2.0,2.0) " +
                "Your answer was: " + area);

            area = Ex3.Program.triangleArea(2.0,0.0,2.0);
            Assert.True(area == -1.0,
                "If at least one side of the triangle is not valid " +
                "the return value should be -1.\n" +
                "Test Data: (2.0,0.0,2.0) " +
                "Your answer was: " + area);

            area = Ex3.Program.triangleArea(2.0,2.0,0.0);
            Assert.True(area == -1.0,
                "If at least one side of the triangle is not valid " +
                "the return value should be -1.\n" +
                "Test Data: (2.0,2.0,0.0) " +
                "Your answer was: " + area);

            area = Ex3.Program.triangleArea(0.0,0.0,0.0);
            Assert.True(area == -1.0,
                "If at least one side of the triangle is not valid " +
                "the return value should be -1.\n" +
                "Test Data: (0.0,0.0,0.0) " +
                "Your answer was: " + area);

            area = Ex3.Program.triangleArea(-1.0,2.0,2.0);
            Assert.True(area == -1.0,
                "If at least one side of the triangle is not valid " +
                "the return value should be -1.\n" +
                "Test Data: (-1.0,2.0,2.0) " +
                "Your answer was: " + area);

            area = Ex3.Program.triangleArea(2.0,-2.0,2.0);
            Assert.True(area == -1.0,
                "If at least one side of the triangle is not valid " +
                "the return value should be -1.\n" +
                "Test Data: (2.0,-2.0,2.0) " +
                "Your answer was: " + area);

            area = Ex3.Program.triangleArea(2.0,2.0,-2.0);
            Assert.True(area == -1.0,
                "If at least one side of the triangle is not valid " +
                "the return value should be -1.\n" +
                "Test Data: (2.0,2.0,-2.0) " +
                "Your answer was: " + area);
        }
    }
}
