using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        //public int Id;
        //public string Model;
        //public int Speed;

        public int Id { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        ///clr will alwyas create a default constructor 
        ///if no user defined constructor exist
        //public Car(){ } //=>Do Nothing 

        public Car(int _Id, string _Model, int _Speed)
        {
            Id = _Id;
            Model = _Model;
            Speed = _Speed;
            Console.WriteLine("Ctor 04");
        }

        public Car(int _Id, string _Model) : this(_Id, _Model, 320)
        {
            //Id = _Id;
            //Model = _Model;
            //Speed = 320;
            Console.WriteLine("Ctor 03");
        }

        public Car(int _Id) : this(_Id, "BMW")
        {
            //Id = _Id;
            //Model = "BMW";
            //Speed = 320;
            Console.WriteLine("Ctor 02");
        }
        public Car() : this(10)
        {
            //Id = 10;
            //Model = "BMW";
            //Speed = 320;
            Console.WriteLine("Ctor 01");
        }
    }
}
