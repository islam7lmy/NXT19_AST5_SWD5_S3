using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Static
{
    /// Static Class
    /// is a just Container For Static Members [Attribute, Property, Constructor, Method] 
    /// You Can't Create Object From This Class (Helper Class)
    /// No Inheritance for this Class
    internal static class Utility
    {
        //static method
        public static void Swap(ref int obj1, ref int obj2)
        {
            int temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        /// Static Constructor [Maximum Only One Static Constructor Per Class]
        /// Can't Specifiy Access Modifiers or Parameters for Static Constructor
        /// Will be Executed Just Only One Time Per Class Lifetime Before the firts Usage of Class
        /// Usages Of Class
        /// 1. Call Static Mehtod or Static Property
        /// 2. set value for static property or filed
        static Utility()
        {
            Print("Hello");
            PI = 3.14159;
        }

        public static double PI { get; }

        public static double CalculateCircleArea(double radius)
        {
            return PI * radius * radius;
        }
    }
}
