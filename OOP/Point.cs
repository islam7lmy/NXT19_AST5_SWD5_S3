using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Point
    {
        /// What You Can Write Inside The Class Or Struct?
        /// 1. variables => fields (Attributes)
        /// 2. functions => Methods
        /// 3. Constructor => special method
        /// 4. Properties
        /// 5. Events
        /// 6. Indexers

        public int X;
        public int Y;

        /// clr will create default constructor for struct
        /// that  will initialize the fields with default values
        /// you can't create user-defined parameterless constructor
        /// inside struct (Except c# 10.0)

        public Point()
        {
            X = default;
            Y = default;
        }

        //public Point(int X , int Y)
        //{
        //    this.X = X;
        //    this.Y = Y;
        //}

        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }

    }
}
