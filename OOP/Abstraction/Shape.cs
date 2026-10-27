using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    interface IShape
    {
        double Perimeter { get; }
        double Area { get; }
    }

    ///not fully implmented => can't create object from it
    abstract class BaseShape : IShape
    {
        ///not implmented method
        public abstract double Perimeter { get; }

        ///fully implmented method
        public virtual double Area { get; }

        ///fully implmented method
        public static double EnsurePostive(double value, string Parmname)
        {
            if (value <= 0)
                throw new ArgumentException($"{Parmname} must be greater than zero");
            return value;
        }
    }

    class Squere : BaseShape
    {
        public double Side { get; }

        public Squere(double _side)
        {
            //Side = EnsurePostive(_side, "Side"); //not recomended

            Side = EnsurePostive(_side, nameof(Side));

            //if (_side <= 0)
            //    throw new ArgumentException($"Side must be greater than zero");
            //Side = _side;
        }

        ///dervied attribute
        public override double Perimeter { get { return Side * 4; } }

        public override double Area { get { return Side * Side; } }

        void test()
        {
            //Side = 30; //not valid
        }

        //public double CalcPerimeter()
        //{
        //    return Side * 4;
        //}

        //public double CalcArea()
        //{
        //    return Side * Side;
        //}
    }

    class Rectangle : BaseShape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double _width, double _height)
        {
            Width = EnsurePostive(Width, nameof(Width));
            Height = EnsurePostive(Height, nameof(Height));

            //if (_width <= 0)
            //    throw new ArgumentException($"Width must be greater than zero");
            //if (_height <= 0)
            //    throw new ArgumentException($"Height must be greater than zero");
            //Width = _width;
            //Height = _height;
        }

        public override double Perimeter { get { return 2 * (Width + Height); } }
        public double Area { get { return Width * Height; } }
    }
}
