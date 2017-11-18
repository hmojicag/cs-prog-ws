/**
    Write a program that tells wheter a number is prime
    or not.

    A prime number is a positive integer that has exactly
    two positive integer factors, 1 and itself. 

    Another way of saying this is that a prime number is a
    positive integer that is not the product of two smaller positive integers.

    For example:
    Given: number = 2
    Returns: true

    Given: number = 15
    Returns: false

    Given: number = -1 (or any negative)
    Returns: false

    Method signature:     isPrime(int number)
    Return value:         bool
    Access modifier:      public static
 */

using System;

namespace Ex9
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public static bool isPrime(int number) {
            if (number < 2) {
                return false;
            }

            for (int i = 2; i < number; i ++) {
                //Loop through all numbers between 2 and number
                if (number % i == 0) {
                    //If it divides then it's not prime
                    return false;
                }
            }
            return true;
        }
    }
}
