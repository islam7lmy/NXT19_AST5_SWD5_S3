using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_OverRiding
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void ShowRole()
        {
            Console.WriteLine("I am Employee");
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine($"Employee : Id = {Id} , Name = {Name} , Age = {Age}");
        }
    }

    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public new void ShowRole()
        {
            Console.WriteLine("I am FullTimeEmployee");
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"FullTimeEmployee : Id = {Id} , Name = {Name} , Age = {Age} , Salary = {Salary}");
        }
    }

    internal class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }
        public new void ShowRole()
        {
            Console.WriteLine("I am PartTimeEmployee");
        }
        public new void PrintDetails()
        {
            Console.WriteLine($"PartTimeEmployee : Id = {Id} , Name = {Name} , Age = {Age} , HourRate = {HourRate} , CountOfHours = {CountOfHours}");
        }
    }

    internal class FreeLanceEmployee : Employee
    {
        public decimal ProjectPrice { get; set; }

        //public void ShowRole()
        //{
        //    Console.WriteLine("I am FreeLanceEmployee");
        //}
        //public void PrintDetails()
        //{
        //    Console.WriteLine($"FreeLanceEmployee : Id = {Id} , Name = {Name} , Age = {Age} , ProjectPrice = {ProjectPrice}");
        //}
    }

    class DayFullTimeEmployee : FullTimeEmployee
    {

    }
    class NightFullTimeEmployee : FullTimeEmployee
    {
        public new void ShowRole()
        {
            Console.WriteLine("I am NightFullTimeEmployee");
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"NightFullTimeEmployee : Id = {Id} , Name = {Name} , Age = {Age} , Salary = {Salary}");
        }
    }

}
