using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Sealed
{
    internal class Parent
    {
        private int salary;
        public virtual int Salary
        {
            get { return salary; }
            set { salary = value - 1000; }
        }
        public virtual void Print()
        {
            Console.WriteLine("Hello Parent");
        }
    }

    class Child02 : Parent
    {
        //salary will be reduced by 1500 
        public override int Salary
        {
            get => base.Salary;
            set => base.Salary = value - 500;
        }

        public override void Print()
        {
            Console.WriteLine("Hello Child02");
        }
    }

    class Child : Parent
    {
        //salary will be reduced by 1500 
        public override int Salary
        {
            get => base.Salary;
            set => base.Salary = value - 500;
        }

        public sealed override void Print()
        {
            Console.WriteLine("Hello Child");
        }
    }

    sealed class GrandChild : Child
    {
        //dynamic polymorphism will not work here because the Print method is sealed in the Child class
        //public override void Print()
        //{
        //    Console.WriteLine("Hello GrandChild");
        //}

        //but you can use new keyword to hide the base class method
        //public new void Print()
        //{
        //    Console.WriteLine("Hello GrandChild");
        //}

    }

    //class GrandGrandChild : GrandChild
    //{
        
    //}


}
