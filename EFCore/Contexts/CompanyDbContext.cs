using EFCore.Configurations;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Contexts
{
    internal class CompanyDbContext : DbContext
    {
        ///OnConfiguring => configuration Of Database Server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Your_Connection_String_Here");
            optionsBuilder.UseSqlServer("Data Source=Islam7lmyLapVM\\ISLAM7LMY;Initial Catalog=NXT19.EFMyCompany;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer("Data Source = Islam7lmyLapVM\\ISLAM7LMY; Intial Catalog = NXT19.EFMyCompany; Integrated Security = True; Encrypt = False; Trust Server Certificate = True");
            //optionsBuilder.UseSqlServer("Data Source = Islam7lmyLapVM\\ISLAM7LMY; Intial Catalog = NXT19.EFMyCompany; User Id = sa; Password = 1234567; Encrypt = False; Trust Server Certificate = True");
        }

        /// OnModelCreating => Models of Database [table]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // when inhert from dbcontext contain dbsets as scurity modual has 7 dbsets
            // inhert IdentityDbContext
            //base.OnModelCreating(modelBuilder);

            #region 3. Fluent API
            #region ways To access Property
            //modelBuilder.Entity<Employee>()
            //    .Property("FirstName")
            //    .HasDefaultValue("N/A");

            //modelBuilder.Entity<Employee>()
            //    .Property(nameof(Employee.FirstName))
            //    .HasDefaultValue("N/A");

            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.FirstName)
            //    .HasDefaultValue("N/A");
            #endregion
            #region Shadow Property
            //modelBuilder.Entity<Employee>()
            //    .Property<string>("Address")
            //    .HasColumnType("nvarchar(50)");
            #endregion
            #region MappingClass
            //modelBuilder.Entity<Department>()
            //    .ToTable("DepartmentInfo", "dbo")
            //    .HasKey(d => d.DeptId);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.DeptId)
            //    .UseIdentityColumn(10, 10);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.Name)
            //    .HasColumnName("DepartmentName")
            //    .HasColumnType("Nvarchar(50)")
            //    .IsRequired();

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.CreationDate)
            //    .HasColumnType("Date")
            //    .HasComputedColumnSql("GETDATE()");

            ///efcore 3.1 new feature
            //modelBuilder.Entity<Department>(d =>
            //{
            //    d.ToTable("DepartmentInfo", "dbo")
            //        .HasKey(d => d.DeptId);
            //    d.Property(d => d.DeptId)
            //    .UseIdentityColumn(10, 10);

            //    d.Property(d => d.Name)
            //        .HasColumnName("DepartmentName")
            //        .HasColumnType("Nvarchar(50)")
            //        .IsRequired();

            //    d.Property(d => d.CreationDate)
            //        .HasColumnType("Date")
            //        .HasComputedColumnSql("GETDATE()");

            //});

            #endregion
            #endregion

            #region 4. ConfigurationClass Per Entity => Organized 3rd way
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #endregion
        }

        #region DbSet
        public DbSet<Employee> Employees { get; set; }
        #endregion

    }
}
