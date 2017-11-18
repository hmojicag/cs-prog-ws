/**
    Write a program that returns the first n prime
    numbers as comma separated values in a string.

    A prime number is a positive integer that has exactly
    two positive integer factors, 1 and itself. 

    Another way of saying this is that a prime number is a
    positive integer that is not the product of two smaller positive integers.
    For example:
    Given: n = 3
    Return: "2,3,5"

    Given: n = 0 (or any negative)
    Return: ""

    Given: n = 10
    Return: "2,3,5,7,11,13,17,19,23,29"

    Method signature:     findFirstPrimeNumbers(int n)
    Return value:         string
    Access modifier:      public static
 */

using System;

namespace Ex10
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public static string findFirstPrimeNumbers(int n) {
            if (n < 1) {
                return "";
            }            
            if (n == 1) {
                return "2";
            }

            string primes = "2";
            int primeCount = 1;
            int i = 3;
            while(true) {
                if (isPrime(i)) {
                    primes += "," + i;
                    primeCount++;
                }
                if (primeCount >= n) {
                    break;
                }
                i++;
            }
            return primes;
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
