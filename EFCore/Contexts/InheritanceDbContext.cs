using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Contexts
{
    internal class InheritanceDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Islam7lmyLapVM\\ISLAM7LMY;Initial Catalog=NXT19.EFInheritance;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            #region TPH
            //modelBuilder.Entity<FullTime>().HasBaseType<Person>();
            //modelBuilder.Entity<PartTime>().HasBaseType<Person>();
            //modelBuilder.Entity<Person>()
            //    .ToTable("Persons")
            //    .HasDiscriminator<string>("PersonType")
            //    .HasValue<FullTime>("FullTime")
            //    .HasValue<PartTime>("PartTime");
            #endregion
            #region TPT
            //modelBuilder.Entity<Person>().ToTable("Persons");
            //modelBuilder.Entity<FullTime>().ToTable("FullTime");
            //modelBuilder.Entity<PartTime>().ToTable("PartTime");
            #endregion
            #region TPC
            modelBuilder.Entity<FullTime>().UseTpcMappingStrategy();
            modelBuilder.Entity<PartTime>().UseTpcMappingStrategy();
            #endregion
        }

        #region TPH
        #region Two DbSet
        //public DbSet<FullTime> FullTimePerson { get; set; }
        //public DbSet<PartTime> PartTimePerson { get; set; }
        #endregion
        #region One DbSet
        //public DbSet<Person> Persons { get; set; }
        #endregion
        #endregion

        #region TPT
        //public DbSet<Person> Persons { get; set; }
        //public DbSet<FullTime> FullTimePerson { get; set; }
        //public DbSet<PartTime> PartTimePerson { get; set; }
        #endregion

        #region TPC
        public DbSet<FullTime> FullTimePerson { get; set; }
        public DbSet<PartTime> PartTimePerson { get; set; }
        #endregion
    }
}
