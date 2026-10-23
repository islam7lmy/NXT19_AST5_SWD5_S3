using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public Employee()
        {

        }
        /// copy constructor => a constructor that takes an object of the same class as a parameter 
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Salary = emp.Salary;
            Address = emp.Address;
        }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Address} :: {Salary}";
        }

        public static Employee DeepCopy(Employee emp)
        {
            //Employee newemp = new Employee();
            //newemp.Id = emp.Id;
            //newemp.Name = emp.Name;
            //newemp.Salary = emp.Salary;
            //newemp.Address = emp.Address;

            //return newemp;


            //return new Employee()
            //{
            //    Id = emp.Id,
            //    Name = emp.Name,
            //    Salary = emp.Salary,
            //    Address = emp.Address
            //};

            return new Employee(emp);

        }

        public object Clone()
        {
            return new Employee(this);
        }

        //+ve : this > emp
        //-ve : this < emp
        //0 : this == emp

        public int CompareTo(Employee emp)
        {
            //if (this.Salary > emp.Salary)
            //    return 1;
            //else if (this.Salary < emp.Salary)
            //    return -1;
            //else
            //    return 0;

            return this.Salary.CompareTo(emp.Salary);
        }

        public int CompareTo(object? obj)
        {
            Employee emp = (Employee)obj;
            return this.Salary.CompareTo(emp.Salary);
        }
    }
}
