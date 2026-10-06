using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Employee
    {
        //clr will create default constructor to instilize fields with default value
        public Employee()
        {
            Id = default;
            Name = default; //null
            Salary = default;
            Age = default;
        }

        public Employee(int Id, string Name, decimal Salary, int Age)
        {
            this.SetName(Name); //this.Name = Name.Length <= 20 ? Name : Name.Substring(0, 20);
            this.Salary = Salary;
            this.Age = Age;
            this.Id = Id;

        }


        public int Id;

        //encapsulation : seprate the data defintion (attributes) from it's usage (GetterSetter or Property)
        #region Name [Getter Setter Methods]
        string Name; // max length 20 

        public string GetName()
        {
            return Name ?? "N/A";
        }

        public void SetName(string Name)
        {
            this.Name = Name.Length <= 20 ? Name : Name.Substring(0, 20);
        }
        #endregion

        #region Salary [Full Property] => Field + Property (methods)
        //decimal Salary; // min 2000 

        //public decimal GetSalary()
        //{
        //    return Salary < 2000 ? 2000 : Salary;
        //}
        //public void SetSalary(decimal Salary)
        //{
        //    this.Salary = Salary < 2000 ? 2000 : Salary;
        //}

        //propfull + tab + tab
        private decimal _salary; //=> field

        public decimal Salary   //=> property 
        {
            get { return _salary < 2000 ? 2000 : _salary; }
            set { _salary = value < 2000 ? 2000 : value; }
        }
        #endregion

        #region Age [Automatic Property] => backingfield (hidden private field) + property
        //public int Age; 

        //private int _age;

        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
        //}

        //prop + tab + tab
        //clr will generate backingfield (hidden private field)
        public int Age { get; private set; }

        public int _Age;
        #endregion

        #region Deductions [automatic property has only get]
        public decimal Deductions { get { return Salary * .2m; } }
        #endregion


    }
}
