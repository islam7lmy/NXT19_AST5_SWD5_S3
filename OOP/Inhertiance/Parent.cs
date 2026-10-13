using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inhertiance
{
    class Parent
    {
        public int A { get; set; }

        //clr will ccreate default constructor 
        //public Parent()
        //{

        //}

        public Parent(int _a)
        {
            A = _a;
        }

        public void MyFun01()
        {
            Console.WriteLine("Hi I am Parent");
        }

        public void MyFun02()
        {
            Console.WriteLine($"A = {A}");
        }

    }

    class Child : Parent
    {
        //prop => [backingfield + property] || propfull => [field + property]

        //public int A { get; set; }
        public int B { get; set; }

        //clr will ccreate default constructor 
        //public Child() : base()
        //{

        //}


        //clr will not create default constructor because there is a user defined constructor exists
        public Child(int _a, int _b) : base(_a)
        {
            //A = _a;
            B = _b;
        }

        //public void MyFun01()
        //{
        //    Console.WriteLine("Hi I am Chid");
        //}

        //public void MyFun02()
        //{
        //    Console.WriteLine($"A = {A} , B = {B}");
        //}
    }

    class Child01 : Parent
    {
        //prop => [backingfield + property] || propfull => [field + property]

        //public int A { get; set; }
        public int Z { get; set; }

        //clr will not create default constructor because there is a user defined constructor exists
        public Child01(int _a, int _z) : base(_a)
        {
            //A = _a;
            Z = _z;
        }

        //public void MyFun01()
        //{
        //    Console.WriteLine("Hi I am Chid01");
        //}

        //public void MyFun02()
        //{
        //    Console.WriteLine($"A = {A} , Z = {Z}");
        //}
    }
}
