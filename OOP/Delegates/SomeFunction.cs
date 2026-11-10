using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Delegates
{
    internal class SomeFunction
    {
        /// predicate<string>
        public static bool test(string str) { return str.Length > 1; }

        // Func<int , string>
        public static string Cast(int str) { return str.ToString(); }

        // action => not return
        public static void Print() { Console.WriteLine("hello"); }

        // action<string>
        public static void Print(string str) { Console.WriteLine($"hello {str}"); }
    }
}
