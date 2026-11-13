using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        #region DbSet
        public DbSet<Employee> Employees { get; set; } 
        #endregion

    }
}
