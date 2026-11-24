using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class FullTime : Person
    {
        public decimal Salary { get; set; }
        public DateOnly HiringDate { get; set; }
    }

    class PartTime : Person
    {
        public decimal HourRate { get; set; }
        public int HoursCount { get; set; }
    }
}
