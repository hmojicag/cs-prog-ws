/**
    Write a program that given the length of the 3 sides
    of a triangle, it calculates the area.
    Remember that side lenghts of zero and negatives are not valid.
    In the case of an error or bad parameter values
    -1 should be returned.
    Method signature:     triangleArea(double a, double b, double c)
    Return value:         double
    Access modifier:      public static
 */

using System;
namespace Ex3
{
    public class Program
    {
        public static bool ENABLED = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static double triangleArea(double a, double b, double c) {
            if (a <= 0 || b <= 0 || c <= 0) {
                return -1.0;
            }
            return (a + b + c) / 2.0;
        }
    }
}
