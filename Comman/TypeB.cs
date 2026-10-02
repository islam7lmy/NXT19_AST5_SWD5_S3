using Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    internal class TypeB
    {
        void test()
        {
            rank myrank = rank.junior;
            TypeA a = new TypeA();
            //a.x = 10; // not valid because x is private
            a.y = 10; // valid because y is internal and TypeB is in the same assembly as TypeA
            a.z = 30; // valid because z is public and we are inside the class

        }
    }
}

namespace test2
{
  class test1
    {
        void test()
        {
            rank myrank = rank.junior;
            TypeA a = new TypeA();
            //a.x = 10; // not valid because x is private
            a.y = 10; // valid because y is internal and TypeB is in the same assembly as TypeA
            a.z = 30; // valid because z is public and we are inside the class
        }
    }
}
