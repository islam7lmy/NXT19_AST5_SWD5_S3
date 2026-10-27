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
        /// ++
        /// --
        /// >
        /// ==
    }
}
