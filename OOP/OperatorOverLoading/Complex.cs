using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OperatorOverLoading
{
    internal class Complex
    {
        public int Real { get; private set; }
        public int Imag { get; private set; }

        private Complex()
        {

        }

        public Complex(int _real, int _imag)
        {
            Real = _real;
            Imag = _imag;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        

        ///operator overloading
        public static Complex operator +(Complex a, Complex b)
        {
            //Complex c = new Complex(
            //    (a?.Real ?? 0)
            //    +
            //    (b?.Real ?? 0),

            //    (a?.Imag ?? 0)
            //    +
            //    (b?.Imag ?? 0)
            //    );
            //return c;

            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) + (b?.Imag ?? 0)
            };

        }

        ////[quiz]
        /// -
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) - (b?.Imag ?? 0)
            };

        }

        /// ++
        public static Complex operator ++(Complex a)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + 1,
                Imag = (a?.Imag ?? 0) + 1
            };

        }
        /// --
        public static Complex operator --(Complex a)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - 1,
                Imag = (a?.Imag ?? 0) - 1
            };

        }

        /// >
        public static bool operator >(Complex a, Complex b)
        {
            if ((a?.Real ?? 0) == (b?.Real ?? 0))
                return (a?.Imag ?? 0) > (b?.Imag ?? 0);

            return (a?.Real ?? 0) > (b?.Real ?? 0);
        }

        public static bool operator <(Complex a, Complex b)
        {
            if ((a?.Real ?? 0) == (b?.Real ?? 0))
                return (a?.Imag ?? 0) < (b?.Imag ?? 0);

            return (a?.Real ?? 0) < (b?.Real ?? 0);
        }

        /// ==
        public static bool operator ==(Complex a, Complex b)
        {
            if ((a?.Real ?? 0) == (b?.Real ?? 0))
                return (a?.Imag ?? 0) == (b?.Imag ?? 0);

            return false;
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }

        //public override bool Equals(object? obj)
        //{
        //    Complex complex = (Complex)obj;
        //    //this => calling object
        //    return (this == complex);
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Real , Imag);
        //}

        public override bool Equals(object? obj)
        {
            return obj is Complex complex &&
                   Real == complex.Real &&
                   Imag == complex.Imag;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Real, Imag);
        }
    }
}
