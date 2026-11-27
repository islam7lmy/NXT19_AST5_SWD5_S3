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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> d)
        {
            d.ToTable("DepartmentInfo", "dbo")
                .HasKey(d => d.DeptId);
            d.Property(d => d.DeptId)
            .UseIdentityColumn(10, 10);

            d.Property(d => d.Name)
                .HasColumnName("DepartmentName")
                .HasColumnType("Nvarchar(50)")
                .IsRequired();

            //d.Property(d => d.CreationDate)
            //    .HasColumnType("Date")
            //    .HasComputedColumnSql("GETDATE()");

            //d.HasMany(x => x.Employees)
            //    .WithOne(e => e.Department)
            //    .HasForeignKey(e => e.DepartmentDeptId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //d.HasOne(d => d.Manager)
            //    .WithOne(e => e.DepartmentToManage)
            //    .HasForeignKey<Department>(d => d.ManagerId)
            //    .OnDelete(DeleteBehavior.Cascade);

            d.HasOne<Employee>()
                .WithOne()
                .HasForeignKey<Department>(d => d.ManagerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
