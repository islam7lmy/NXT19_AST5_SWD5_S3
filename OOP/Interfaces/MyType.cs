using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    /// interface : is a contract that define a set of
    /// methods, properties, events, or indexers that a class or struct must implement.
    interface IMyType
    {
        /// What You Can Write Inside The Interface?
        /// 1. Method Signature
        /// 2. property Signature
        /// 3. event Signature
        /// 4. indexer signature
        /// 5. Default Implementation (C# 8.0 +)

        /// default access modifiers inside the interface is public
        /// private is not allowed inside the interface

        /// property Signature
        int Salary { get; set; }

        //Method Signature
        void Myfun();

        //Default Implementation
        void Print()
        {
            Console.WriteLine("Hello I am Default Implementation");
        }

    }

    internal class MyType : IMyType // => implmentation
    {
        ///clr will generate Backingfield
        //public int Salary { get; set; }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value <= 2000 ? 2000 : value; }
        }

        public void Myfun()
        {
            Console.WriteLine("Hello");
        }

        /// work as override
        public void Print()
        {
            Console.WriteLine("hello I am MyType");
        }

    }

    internal class MyTypev2 : IMyType
    {
        ///clr will generate Backingfield
        //public int Salary { get; set; }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value - 1000; }
        }

        public void Myfun()
        {
            Console.WriteLine("Hello Print");
        }

    }
}
