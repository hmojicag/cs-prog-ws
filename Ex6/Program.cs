/**
    Write a program that program that given two numbers
    number1, number2 and an string representing an operator
    ("*", "-", "/" and "^"), it applies the operation
    and returns the result.
    If anything goes wrong it should return 0.0.
    For example:
    1) using number1 = 5, number2 = 10 and op = "*" will return 50
    2) using number1 = 100, number2 = 20 and op = " - " will return 80
    And so forth...
    
    Method signature:     Calculate(double number1, double number2, string op)
    Return value:         double
    Access modifier:      public static
 */

using System;
namespace Ex6
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static double Calculate(double number1, double number2, string op) {
            if (String.IsNullOrEmpty(op)) {
                return 0.0;
            } else if (op.Trim().Equals("*")) {
                return number1 * number2;
            } else if (op.Trim().Equals("+")) {
                return number1 + number2;
            } else if (op.Trim().Equals("-")) {
                return number1 - number2;
            } else if (op.Trim().Equals("/")) {
                if (number2 == 0.0) {
                    return 0.0;
                } else {
                    return number1 / number2;
                } 
            } else if (op.Trim().Equals("^")) {
                return Math.Pow(number1, number2);
            }
            return 0.0;
        }
    }
}
