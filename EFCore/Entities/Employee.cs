using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    //internal class Employee
    //{
    //    /// primary key => [id] , [classname + id]
    //    public int EmployeeId { get; set; }
    //    //public int Id { get; set; } // primary key by convanion => identity(1,1) => not allow null
    //    public string FirstName { get; set; } // nvarchar(Max) => not allow null
    //    public string? LastName { get; set; } // nvarchar(Max) => allow null
    //    public double Salary { get; set; } // float => not allow null
    //    public int? Age { get; set; } // int =>  allow null
    //}
    #endregion

    #region 2. Data Annotations [set of attributes used for valdation]
    //[Table("EmployeeInfo",Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int EmployeeCode { get; set; }

    //    [Required]
    //    [Column(TypeName = DBTypes.Nvarchar)]//[Column(TypeName = "nvarchar")]
    //    [MaxLength(100)]
    //    [StringLength(50,MinimumLength = 10)]
    //    public string? FirstName { get; set; } 
    //    public string? LastName { get; set; } 
    //    public double Salary { get; set; }
    //    [Range(22,60)]
    //    public int? Age { get; set; }
    //    [NotMapped]
    //    public int test { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; }
    //}
    #endregion

    #region 3. Fluent API
    //internal class Employee
    //{
    //    public int EmployeeId { get; set; }
    //    public string FirstName { get; set; }
    //    public string? LastName { get; set; }
    //    public double Salary { get; set; }
    //    public int? Age { get; set; }
    //}
    #endregion


    #endregion

    #region RealationShipMapping
    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public double NetSalary => Salary * .9;

        ///class name + pk
        //[ForeignKey(nameof(Department))]
        public int DepartmentDeptId { get; set; }

        //[InverseProperty(nameof(Department.Employees))]
        //public Department Department { get; set; }

        //[InverseProperty(nameof(Department.Manager))]
        //public Department? DepartmentToManage { get; set; }

    }
    #endregion

    public static class DBTypes
    {
        public const string Varchar = "varchar";
        public const string Nvarchar = "nvarchar";
        public const string Int = "int";
        public const string Float = "float";
    }
}
