using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal interface IMoveable
    {
        int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();
    }
    internal interface IFlyable
    {
        int Speed { get; set; }
        void Forward();
        void Left();
        void Right();
    }

    class Car : IMoveable , ICloneable
    {
        public int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Car is move BackWard");
        }

        public object Clone()
        {
            return new object();
        }

        public void Forward()
        {
            Console.WriteLine("Car is move Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car is move Left");
        }

        public void Right()
        {
            Console.WriteLine("Car is move Right");
        }
    }

    class AirPlan : IMoveable,IFlyable
    {
        public int Speed { get; set; }

        void IMoveable.Backward()
        {
            Console.WriteLine("AirPlany is move Backward");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("AirPlany is move Forward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("AirPlany is Fly Forward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("AirPlany is move Left");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("AirPlany is Fly Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("AirPlany is move Right");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("AirPlany is Fly Right");
        }
    }

}
