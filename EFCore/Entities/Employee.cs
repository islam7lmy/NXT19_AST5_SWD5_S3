using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    #region Properties Mapping
    /// Ef Core Suppotes 4 ways for mapping
    /// 1. by Convention (Default)
    /// 2. Data Annotations [set of attributes used for valdation]
    /// 3. Fluent API (set of methods to do congfigurations)
    /// 4. ConfigurationClass Per Entity => Organized 3rd way 


    #region 1. by Convention (Default Bhavior)
    internal class Employee
    {
        /// primary key => [id] , [classname + id]
        public int EmployeeId { get; set; }
        //public int Id { get; set; } // primary key by convanion => identity(1,1) => not allow null
        public string FirstName { get; set; } // nvarchar(Max) => not allow null
        public string? LastName { get; set; } // nvarchar(Max) => allow null
        public double Salary { get; set; } // float => not allow null
        public int? Age { get; set; } // int =>  allow null
    }  
    #endregion
    #endregion
}
