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

        public Car(int _Id,string _Model,int _Speed)
        {
                
        }
    }
}
