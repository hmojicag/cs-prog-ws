/**
    Write a program that given two arrays of strings
    returns a new array with the elements of both
    alternated.

    For example:
    Given: array1=["1","2","3"], array2=["a","b", "c"]
    Returns: ["1","a","2","b","3","c"]

    Given: array1=["1","2"], array2=["a","b", "c"]
    Returns: ["1","a","2","b","c"]

    Given: array1=["1","2","3"], array2=["a","b"]
    Returns: ["1","a","2","b","3"]

    Given: array1=[] <- Empty or null, array2=["a","b", "c"]
    Returns: ["a","b","c"]

    Method signature:     arrayAlternated(string[] array1, string[] array2)
    Return value:         string[]
    Access modifier:      public static
 */

using System;

namespace Ex12
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Pancho");
        }

        public static string[] arrayAlternated(string[] array1, string[] array2) {
            //Find the new array length
            int l1 = array1 == null ? 0 : array1.Length;
            int l2 = array2 == null ? 0 : array2.Length;
            string[] concatArray = new string[l1+l2];
            //Find the greatest array length
            int lMax = l1 > l2 ? l1 : l2;
            
            int concatIndex = 0;
            for (int i = 0; i < lMax; i++) {
                if (i < l1) {//Add array1 item
                    concatArray[concatIndex] = array1[i];
                    concatIndex++;
                }
                if (i < l2) {//Add array2 item
                    concatArray[concatIndex] = array2[i];
                    concatIndex++;
                }
            }

            return concatArray;
        }

    }
}
