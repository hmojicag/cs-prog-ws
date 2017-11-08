/**
    Write a program that given a string it returns the same
    string but without any white space.
    For example: Given "Hello Joe Doe ".
    A null string value should return an empty string.
    It returns "HelloJoeDoe"
    Method signature:     SupressWhiteSpaces(string text)
    Return value:         string
    Access modifier:      public static
 */

using System;
namespace Ex5
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string SupressWhiteSpaces(string text) {
            if (text == null) {
                return string.Empty;
            }
            return text.Replace(" ", "");
        }
    }
}
