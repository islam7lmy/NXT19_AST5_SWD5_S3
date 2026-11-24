using EFCore.Contexts;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region How To Migrate
            //to add db to sql server:

            ///1.Install-Package "Microsoft.EntityFrameworkCore.SqlServer" -version 9.0.23
            ///2.create Compnydbcontext that inhert DbContext
            ///3.override OnConfiguring and set db conection string
            ///4.add dbset<> for class (Models) that want to be tables
            ///5.install Package Microsoft.EntityFrameworkCore.Tools
            ///6.Add-Migration "InitialCreate"
            ///7.Update-Database
            #endregion

            #region CRUD Operations [create, read, update, delete]
            //unmanaged code
            //CompanyDbContext db = new CompanyDbContext();
            //try
            //{
            //}
            //finally
            //{
            //    db.Dispose(); // close connection
            //}

            //using (CompanyDbContext db2 = new CompanyDbContext()) //managed code
            //{
            //    ///crud
            //    ///code
            //    ///crud
            //}

            //using CompanyDbContext db3 = new CompanyDbContext();//managed code
            /////crud
            /////code
            /////crud


            //using CompanyDbContext db = new CompanyDbContext();
            //Employee employee = new Employee()
            //{
            //    FirstName = "ahmed",
            //    LastName = "Ali",
            //    Salary = 3000,
            //    Age = 25
            //};

            //Department dept = new Department() { Name = "Hr" };

            #region Create
            //db.Employees.Add(employee);
            //db.Add(employee);
            //db.Set<Department>().Add(dept);
            //db.Entry(employee).State = EntityState.Added;

            //Console.WriteLine(db.Entry(employee).State); //deattached
            //db.Employees.Add(employee);
            //Console.WriteLine(db.Entry(employee).State); //added
            //db.SaveChanges();
            //Console.WriteLine(db.Entry(employee).State); //unchanged

            //change tracker
            #endregion

            #region Read
            #region Multi Element
            ////in case we have 10_000 Employee
            ////select * from employees => excute in db and save return in local memory [10_000]
            ////
            ////
            ////where employeeid = 1 => u run filter on local memory [1]
            //var result = db.Employees.ToList().Where(e => e.EmployeeId == 1);

            ////select * from employees where employeeid = 1 => excute in db and save return in local memory [1]
            //var Rightresult = db.Employees.Where(e => e.EmployeeId == 1).ToList();

            //var result02 = (from emp in db.Employees
            //                where emp.EmployeeId == 1
            //                select emp
            //                ); //linq => select * from employees where employeeid = 1

            //var result03 = result02.ToList();

            //foreach (Employee emp in result)
            //{
            //    Console.WriteLine($"Id: {emp.EmployeeId}, Name: {emp.FirstName} {emp.LastName}, Salary: {emp.Salary}, Age: {emp.Age}");
            //}
            #endregion
            #region Single Element
            //var emp = //db.Employees.Where(e => e.Age == 25)

            //    (from e in db.Employees
            //     where e.Age == 25
            //     select e)

            //    //.First()  // Top(1) => select top(1) * from employees where employeeid = 1
            //    //.FirstOrDefault()  // Top(1) => select top(1) * from employees where employeeid = 1
            //    //.Single()  // Top(2) => select top(1) * from employees where employeeid = 1
            //    .SingleOrDefault()  // Top(2) => select top(1) * from employees where employeeid = 1
            //;
            //if (emp is not null)
            //    Console.WriteLine($"Id: {emp.EmployeeId}, Name: {emp.FirstName} {emp.LastName}, Salary: {emp.Salary}, Age: {emp.Age}");
            //else
            //    Console.WriteLine("No Data");
            #endregion
            #region Tracking Vs NoTracking
            //db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //var emp = //db.Employees.Where(e => e.EmployeeId == 1)

            //    (from e in db.Employees
            //     where e.EmployeeId == 1
            //     select e)


            //    .AsNoTracking()
            //    .FirstOrDefault();
            //Console.WriteLine(db.Entry(emp).State);

            //var emp01 = //db.Employees.Where(e => e.EmployeeId == 2)

            //    (from e in db.Employees
            //     where e.EmployeeId == 2
            //     select e)

            //    .AsTracking()
            //    .FirstOrDefault();
            //Console.WriteLine(db.Entry(emp01).State);
            #endregion
            #endregion

            #region Update
            //var emp = db.Employees.Where(e => e.EmployeeId == 1).FirstOrDefault();
            //if (emp is not null)
            //{
            //    emp.FirstName = "Updated";
            //    emp.Salary = 6000;
            //    Console.WriteLine(db.Entry(emp).State);
            //    db.Employees.Update(emp);
            //    Console.WriteLine(db.Entry(emp).State);
            //    db.SaveChanges();
            //    Console.WriteLine(db.Entry(emp).State);
            //}
            #endregion

            #region Delete
            //var emp = db.Employees.Where(e => e.EmployeeId == 1).FirstOrDefault();
            //if (emp is not null)
            //{
            //    Console.WriteLine(db.Entry(emp).State);
            //    db.Employees.Remove(emp);
            //    Console.WriteLine(db.Entry(emp).State);
            //    db.SaveChanges();
            //    Console.WriteLine(db.Entry(emp).State);
            //}
            #endregion

            #endregion

            #region Mapping RealtionShip
            ///pk => fk
            ///3. how to implment in code
            ///     3.1 fk property [class name + pk name]
            ///     3.2 Navigational property [class name]
            ///     by defaulty 
            #endregion

            #region Mapping Inhertince
            using InheritanceDbContext dbContext = new InheritanceDbContext();
            FullTime fullTime = new FullTime()
            {
                Name = "Ahmed",
                Age = 22,
                HiringDate = DateOnly.FromDateTime(DateTime.Now),
                Salary = 6000
            };

            PartTime partTime = new PartTime()
            {
                Name = "Ali",
                Age = 25,
                HourRate = 300,
                HoursCount = 10
            };

            Person person = new Person()
            {
                Name = "TestPerson",
                Age = 22
            };

            #region TPH
            #region Two DbSet
            //dbContext.FullTimePerson.Add(fullTime);
            //dbContext.PartTimePerson.Add(partTime);
            //dbContext.SaveChanges();

            //var fullTimePersons = (from f in dbContext.FullTimePerson select f).ToList();
            //var partTimePersons = (from p in dbContext.PartTimePerson select p).ToList();

            #endregion
            #region One DbSet
            ////dbContext.Persons.Add(person);
            //dbContext.Persons.Add(fullTime);
            //dbContext.Persons.Add(partTime);

            //dbContext.SaveChanges();

            //var persons = (from f in dbContext.Persons select f).ToList();
            //var fullTimePersons = (from f in dbContext.Persons.OfType<FullTime>()
            //                       select f).ToList();
            //var partTimePersons = (from p in dbContext.Persons.OfType<PartTime>()
            //                       select p).ToList();
            #endregion

            //Console.WriteLine();
            //Console.WriteLine("****************fulltimeperson**************");
            //foreach (var item in fullTimePersons)
            //    Console.WriteLine($"{item.Id} :: {item.Name} :: {item.Salary}");
            //Console.WriteLine();
            //Console.WriteLine("****************PartTimeperson**************");
            //foreach (var item in partTimePersons)
            //    Console.WriteLine($"{item.Id} :: {item.Name} :: {item.HourRate}");
            //Console.WriteLine();
            //Console.WriteLine("****************Persons**************");
            //foreach (var item in persons)
            //{
            //    Console.WriteLine($"{item.Id} :: {item.Name} :: {item.Age}");
            //}
            #endregion

            #region TPT
            //dbContext.FullTimePerson.Add(fullTime);
            //dbContext.PartTimePerson.Add(partTime);
            //dbContext.Persons.Add(person);
            //dbContext.Persons.Add(fullTime);
            //dbContext.Persons.Add(partTime);
            //dbContext.SaveChanges();

            //var persons = from p in dbContext.Persons
            //              select p;

            //Console.WriteLine("*****************Persons******************");
            //foreach (var item in persons)
            //{
            //    Console.WriteLine($"Employee:{item.Name}, Type: {item.GetType().Name}");
            //}


            //var fullTimePersons = from p in dbContext.FullTimePerson
            //                      select p;

            //Console.WriteLine("*****************fulltime******************");
            //foreach (var item in fullTimePersons)
            //{
            //    Console.WriteLine($"FullTime Employee:{item.Name}, Salary: {item.Salary}");
            //}

            //var partTimePersons = from p in dbContext.PartTimePerson
            //                      select p;

            //Console.WriteLine("*****************parttime******************");
            //foreach (var item in partTimePersons)
            //{
            //    Console.WriteLine($"PartTime Employee:{item.Name}, HourRate: {item.HourRate}");
            //}
            #endregion

            #region TPC
            dbContext.FullTimePerson.Add(FullTime);
            //dbContext.FullTimePerson.Add(person); not valid
            dbContext.PartTimePerson.Add(partTime);
            //dbContext.PartTimePerson.Add(person); not valid
            dbContext.SaveChanges();

            var fullTimePersons = from p in dbContext.FullTimePerson
                                  select p;

            Console.WriteLine("*****************fulltime******************");
            foreach (var item in fullTimePersons)
            {
                Console.WriteLine($"FullTime Employee:{item.Name}, Salary: {item.Salary}");
            }

            var partTimePersons = from p in dbContext.PartTimePerson
                                  select p;

            Console.WriteLine("*****************parttime******************");
            foreach (var item in partTimePersons)
            {
                Console.WriteLine($"PartTime Employee:{item.Name}, HourRate: {item.HourRate}");
            }
            ndregion

            #endregion
            #endregion


            #region work with multi dbcontext
            ///Add-Migration "TPHInitialCreate" -Context "InheritanceDbContext" -OutputDir "MigrationsForInheritanceDbContext"

            ///Update-Database -Context "InheritanceDbContext"
            #endregion

        }
    }
}
