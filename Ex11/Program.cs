/**
    Write a program that given two arrays of strings
    returns a new array with the elements of both
    concatenated.

    For example:
    Given: array1=["Hello","World"], array2=["Hola","Mundo","FIME"]
    Returns: ["Hello","World","Hola","Mundo","FIME"]

    Given: array1=[], array2=["Hola","FIME"]
    Returns: ["Hola","FIME"]

    Given: array1=["Hello","World"], array2=null
    Returns: ["Hello","World"]

    Given: array1=["Hello","World"], array2=null
    Returns: ["Hello","World"]

    Given: array1=[], array2=null
    Returns: []

    Method signature:     arrayConcatenation(string[] array1, string[] array2)
    Return value:         string[]
    Access modifier:      public static
 */

using System;

namespace Ex11
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public static string[] arrayConcatenation(string[] array1, string[] array2) {
            //Find the new array length
            int l1 = array1 == null ? 0 : array1.Length;
            int l2 = array2 == null ? 0 : array2.Length;
            string[] concatArray = new string[l1+l2];

            //Copy content
            int i = 0;
            if (array1 != null) {
                foreach (var item in array1) {
                    concatArray[i] = item;
                    i++;
                }
            }
            if (array2 != null) {
                foreach (var item in array2) {
                    concatArray[i] = item;
                    i++;
                }
            }

            return concatArray;
        }

    }
}
