using System;

namespace Tests {
    public class TestUtils {
        public static bool areEqualArrays(string[] array1, string[] array2) {

            if (array1 == array2) {
                return true;
            }

            if (array1.Length != array2.Length) {
                return false;
            }

            for (int i = 0; i < array1.Length; i++) {
                if (!array1[i].Equals(array2[i])) {
                    return false;
                }
            }

            return true;
        }

        public static string array2String(string[] array) {
            if (array == null) {
                return "null";
            }

            if (array.Length == 0) {
                return "[]";
            }

            if (array.Length == 1) {
                return $"[{array[0]}]";
            }

            string text = $"[{array[0]}";
            for (int i = 1; i < array.Length; i++) {
                text += $", {array[i]}";
            }
            text += "]";
            return text;
        }
    }
}