using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> emp)
        {
            //emp.HasOne(e=>e.Department)
            //    .WithMany(d=>d.Employees)
            //    .HasForeignKey(x=>x.DepartmentDeptId)
            //    .OnDelete(DeleteBehavior.NoAction);

            emp.HasOne<Department>()
                .WithMany()
                .HasForeignKey(e => e.DepartmentDeptId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
