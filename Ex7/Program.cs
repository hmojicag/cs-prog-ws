/**
    Write a program that given one integer number n
    returns the sum of all numbers from 1 to n.
    For example, given n = 5 it returns: 1+2+3+4+5 = 15

    Method signature:     sum2N(int n)
    Return value:         int
    Access modifier:      public static
 */

using System;

namespace Ex7
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int sum2N(int n) {
            int sum = 0;
            for (int i = 1; i <= n; i++) {
                sum += i;
            }
            return sum;
        }
    }
}
