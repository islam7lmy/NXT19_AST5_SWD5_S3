using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Employee
    {
        public int Id;
        public string Name; // max length 20
        public decimal Salary; // min 2000
        public int Age; // min 18 , max 60
    }
}
