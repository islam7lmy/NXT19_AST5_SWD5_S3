using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal class Point : /*IComparable,*/IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            //this 
            //obj
            Point other = (Point)obj; //[unsafe]
            return this.X == other.X && this.Y == other.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        //public int CompareTo(object? obj)
        //{
        //    Point p = (Point)obj;
        //    if (p is null)
        //        return 1;
        //    if (this.X == p.X && Y == p.Y)
        //        return 0;
        //    else
        //        return X.CompareTo(p.X);
        //}

        public int CompareTo(Point? other)
        {
            if (other is null)
                return 1;
            if (this.X == other.X && Y == other.Y)
                return 0;
            else
                return X.CompareTo(other.X);
        }
    }
}
