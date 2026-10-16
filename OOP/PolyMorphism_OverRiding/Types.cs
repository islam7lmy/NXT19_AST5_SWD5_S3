using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_OverRiding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int _a)
        {
            A = _a;
        }

        public void MyFun01()
        {
            Console.WriteLine("I am Type A");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _a, int _b) : base(_a)
        {
            B = _b;
        }

        /// static binded method
        /// apply overriding => new keyword [hidding]
        /// Compilation time
        public new void MyFun01()
        {
            Console.WriteLine("I am Type B");
        }


        /// dynamic binded method
        /// apply overriding => override keyword
        /// to apply override => method of parent must be [not private , virtual]
        /// Runtime
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        }

    }

    class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int _a, int _b, int _c) : base(_a, _b)
        {
            C = _c;
        }

        /// static binded method
        /// apply overriding => new keyword [hidding]
        /// Compilation time
        public new void MyFun01()
        {
            Console.WriteLine("I am Type C");
        }


        /// dynamic binded method
        /// apply overriding => override keyword
        /// to apply override => method of parent must be [not private , virtual]
        /// Runtime
        public override void MyFun02()
        {
            Console.WriteLine($"TypeC : A = {A} , B = {B} , C = {C}");
        }

    }

    class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int _a, int _b, int _c, int _d) : base(_a, _b, _c)
        {
            D = _d;
        }

        public new virtual void MyFun02()
        {
            Console.WriteLine($"TypeD : A = {A} , B = {B} , C = {C} , D = {D} ");
        }
    }

    class TypeE : TypeD
    {
        public int E { get; set; }
        public TypeE(int _a, int _b, int _c, int _d,int _e) : base(_a, _b, _c, _d)
        {
            E = _e;
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeE : A = {A} , B = {B} , C = {C}, D = {D} , E = {E}");
        }
    }
}
