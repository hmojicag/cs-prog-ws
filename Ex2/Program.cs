/**
    Create a program that greets a user.
    For example, if the username is "Arya" the return
    of the program should be  "Greetings Arya".
    If username is null, it will be trated as an empty string
    Method signature:     greetingsUser(string username)
    Return value:         string
    Access modifier:      public static
 */
using System;
namespace Ex2
{
    public class Program
    {
        public static bool ENABLED = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    
        public static string GreetingsUser(string username) {
            string greeting = "Greetings ";
            if (!String.IsNullOrEmpty(username)) {
                greeting += username;
            }
            return greeting;
        }    
    }
}
