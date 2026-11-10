using Comman;
using OOP.Abstraction;
using OOP.Delegates;
using OOP.Events;
using OOP.Generics;
using OOP.Inhertiance;
using OOP.Interfaces;
using OOP.OperatorOverLoading;
using OOP.PolyMorphism_OverRiding;
using OOP.Sealed;
using OOP.Static;
using System.Collections;
using System.Runtime.InteropServices;
//using FirstCode;

namespace OOP
{
    internal class Program
    {
        //new Delegate (Class), the reference from this Delegate Can refer to a function or more than function [pointer to function]
        //these function may be class-member function [static] or object-member function [non-static]
        //but these function must have the same signature of delegate
        //regardless function access modifier regardless naming(Return type, parameters)
        //ref from delegate have object of delegate that has target and this target has function 

        //step 0. Delegate Declare
        public delegate int StringFuncDelegate(string str);


        static void Main(string[] args)
        {
            #region OOP
            #region Access Modifiers
            ///1. private
            ///2. private protected => inhertance
            ///3. protected => inhertance
            ///4. internal
            ///5. protected internal => inhertance
            ///6. public

            //PermissionItem myp = PermissionItem.write;
            //Permission.AddPermission(ref myp, PermissionItem.read, PermissionItem.delete);

            //Console.WriteLine(myp);

            //Console.WriteLine(Helper.Sum(10, 20, 3, 1515, 123));

            //rank myrank = rank.junior;
            /// not valid because it's internal 
            /// only avilable in same asembly

            //TypeA a = new TypeA();
            ////a.x = 10; // not valid because x is private
            ////a.y = 10; //not valid because y is internal and TypeA is in the same assembly as Program
            //a.z = 30; // valid because z is public and we are inside the class

            //TypeC c = new TypeC();
            ////c.x = 10; // not valid because x is private
            ////c.y = 10; //not valid because y is internal and TypeC is in the same assembly as Program
            //c.z = 30; // valid because z is public and we are inside the class


            #endregion

            #region Struct
            #region EX 01: Point
            //Point p1;
            /// allocate 8 bytes uninitialized in the stack memory [4 byte x , 4 byte y]
            //Console.WriteLine(p1);// invalid because not intilized

            //p1.X = 10;
            //p1.Y = 20;
            //Console.WriteLine(p1);

            //p1 = new Point();
            /// new key word just for constructor selection and not for memory allocation in stack memory
            ///that will initialize the struct fields with default values

            //p1 = new Point(100, 200);

            //Console.WriteLine(p1.X);
            //Console.WriteLine(p1.Y); 
            #endregion
            #region EX 02 : Employee
            //Employee emp = new Employee();
            //emp.Name = "ahmed mohmed ahmed ibrahem";
            //emp.Salary = 1000000000;
            ////emp = new Employee("ahmed mohmed ahmed ibrahem");
            //Console.WriteLine(emp.Salary);

            //emp.SetName("ahmed mohmed ahmed ibrahem");

            //Console.WriteLine(emp.GetName());

            //emp.Salary = 20; //property => set
            //Console.WriteLine(emp.Salary); // property => get

            //emp.Age = 20;
            //emp._Age = 20;
            //Console.WriteLine(emp.Age);
            //Console.WriteLine(emp._Age);

            //Console.WriteLine(emp.Deductions);
            //emp.Deductions = 10;
            #endregion
            #region Ex 03 : PhoneBook
            //name => number
            //add contact
            //remove contact
            //get contact
            //set contact

            //numbers arr[0]
            //names arr[0]

            //addcontact(name,number);
            //removecontact(name); //if find contact remove from name arr and number arr
            //getcontact(name); //=> number
            //setcontact(name,number); //if find contact update number

            //PhoneBook book = new PhoneBook();
            ////book.names = new string[5]; 
            ////book.numbers = new string[10]; 

            //Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");
            ////book = new PhoneBook(15);
            ////book.AddContact("ahmed", "01234567891", 0); //=> disable postion make it automatic [quiz]
            ////book.AddContact("ahmed", "01234567123", 0); //=> reset
            ////Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");
            ////book.RemoveContact("ahmed");
            ////Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");
            ////book.AddContact("ahmed", "01234567891", 0);
            //book.AddContact("ahmed", "01234567891");
            //book.AddContact("ali", "01234567892");
            //book.AddContact("omr", "01234567893");
            //book.AddContact("amr", "01234567894");
            //book.AddContact("amr01", "01234567895");
            ////book.SetContact("ahmed", "01234567123");
            ////Console.WriteLine(book.GetContact("ahmed"));
            //Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");


            //book["ahmed"] = "01234567123"; //=> set number
            //Console.WriteLine(book["ahmed"]);

            //// Console.WriteLine(book[0]); // => [quiz]

            //for (int i = 0; i < book.Count; i++)
            //{
            //    Console.WriteLine(book[i]);
            //}
            #endregion
            #endregion

            #region Class
            #region EX: Car
            //Car c1;
            /// declare a reference variable of type Car refer to null
            /// allocate 4 unitialized bytes in stack
            /// zero bytes in heap for the object
            //Console.WriteLine(c1);
            //c1.Id = 1;
            //c1.Model = "BMW";
            //c1.Speed = 320;

            //c1 = new Car();
            //Console.WriteLine($"c1 => {{ {c1.Id} , {c1.Model} , {c1.Speed} }}");
            //c1 = new Car(10);
            //Console.WriteLine($"c1 => {{ {c1.Id} , {c1.Model} , {c1.Speed} }}");
            //c1 = new Car(10, "BMW");
            //Console.WriteLine($"c1 => {{ {c1.Id} , {c1.Model} , {c1.Speed} }}");
            //c1 = new Car(10, "BMW", 320);
            //Console.WriteLine($"c1 => {{ {c1.Id} , {c1.Model} , {c1.Speed} }}");

            //c1 = new Car();

            //c1.Id 

            //Point p1;
            // allocate 8 byte unitialized in stack [4 byte X , 4 byte Y]
            //Console.WriteLine(p1);
            //p1.X = 10;
            //p1.Y = 10;
            //Console.WriteLine(p1);

            //p1 = new Point(); 
            #endregion
            #region Inhertance
            //Child c = new Child(10,20);
            #endregion
            #region Class vs Struct
            //Car c1 = new Car();
            //Car c2 = c1; //shallow copy => both c1 and c2 refer to same object
            //c2.Id = 99;
            //Console.WriteLine(c1.Id); // 99 because c1 and c2 refer to the same object in heap
            ///reference type => stored reference in stack and object in heap
            ///new => allocate required bytes in heap , initilize the required bytes with default value , Call Constructor , make reference refer to allocated bytes
            ///constructor => Do Nothing
            ///default constructor => Clr will generate it if no user-defined constructor exists
            ///support ineritance => [all access modifers]
            ///used calss for complex objects and behaviors



            //Point p1 = new Point();
            //Point p2 = p1; // deep copy => copy the value of p1 and set it in p2
            //p2.X = 99;
            //Console.WriteLine(p1.X); // 0 => because p1 and p2 has different address in stack 
            ///value type => stored in stack 
            ///new => Constructor selector 
            ///constructor => initilize the struct fields with default value
            ///default constructor => Clr will always generate default constructor
            ///cannot inherit from anthor => [private , internal , public]
            ///use for small and simple data => recommanded 16 byte or less


            ///phonebook => struct
            //Console.WriteLine("***************************Struct**************************");
            //PhoneBook book = new PhoneBook();
            //book.AddContact("ahmed", "0000000000");


            //PhoneBook book02 = book;

            //book02.AddContact("ahmed", "0000000000");
            //Console.WriteLine(book.GetContact("ahmed"));  ///0000000000

            //book02.names = new string[10];
            //book02.numbers = new string[10];
            //Console.WriteLine($"{book.names.Length} , {book.numbers.Length}"); // 2
            //Console.WriteLine($"{book02.names.Length} , {book02.numbers.Length}"); // 10

            //book02 = new PhoneBook();
            //Console.WriteLine(book["ahmed"]);
            //Console.WriteLine(book02["ahmed"]);



            //Console.WriteLine("***************************CLASS**************************");

            //PhoneBookClass book03 = new PhoneBookClass();
            //book03.AddContact("ahmed", "0000000000");


            //PhoneBookClass book04 = book03;
            //book04.AddContact("ahmed", "0000000000");
            //Console.WriteLine(book03.GetContact("ahmed")); ///0000000000

            //book04.names = new string[10];
            //book04.numbers = new string[10];
            //Console.WriteLine($"{book03.names.Length} , {book03.numbers.Length}"); // 10

            //book04 = new PhoneBookClass();
            //Console.WriteLine(book03["ahmed"]);
            //Console.WriteLine(book04["ahmed"]);

            #endregion
            #endregion

            #region PolyMorphism
            #region Overloading
            //int x = 10;
            //x.ToString();

            //int num1 = 10, num2 = 20;
            //Sum(num1, num2);

            //double num3 = 1.25, num4 = 12.6;
            //Sum(num3, num4);

            //CalculateTotalForTwoItems();
            //CalculateTotalForThreeItems();
            //CalculateTotalWithDiscount();
            //CalculateTotalWithTax();

            #endregion

            #region OverRiding
            //Comman.TypeA typeA = new Comman.TypeA();

            //PolyMorphism_OverRiding.TypeA typeA01 = new PolyMorphism_OverRiding.TypeA();

            //TypeA typeA = new TypeA(10);
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeB(10, 20);
            //typeB.MyFun01();
            //typeB.MyFun02();
            #endregion
            #endregion

            #region Binding
            //PolyMorphism_OverRiding.Employee emp;
            /////allocate 4 byte for reference from type employee in stack refer to null


            //emp = new PolyMorphism_OverRiding.Employee();
            ////allocate object in heap

            #region What is binding
            /// reference from base type => object from derived type
            /// 
            //PolyMorphism_OverRiding.Employee emp;
            ////emp = new PolyMorphism_OverRiding.Employee(); //not binding

            //emp = new FullTimeEmployee(); //binding
            //emp.Id = 10;
            //emp.Name = "Ahmed";
            //emp.Age = 30;
            ////emp.Salary = 10; //not valid

            //emp.ShowRole();     //hidding => static => reference method
            //emp.PrintDetails(); //overriding => dynamic => object method


            //emp = new PartTimeEmployee();
            //emp.Id = 10;
            //emp.Name = "Ahmed";
            //emp.Age = 30;
            ////emp.HourRate = 100; //not valid
            ////emp.CountOfHour = 20;//not valid

            //emp.ShowRole();     //hidding => static => reference method
            //emp.PrintDetails(); //hidding => static => reference method


            //emp = new FreeLanceEmployee();
            //emp.Id = 10;
            //emp.Name = "Ahmed";
            //emp.Age = 30;
            ////emp.ProjectPrice = 100; //not valid

            //emp.ShowRole();     
            //emp.PrintDetails(); 

            ////emp = new DayFullTimeEmployee();
            ////emp = new NightFullTimeEmployee();


            #endregion

            #region Not Binding
            //FullTimeEmployee emp = (FullTimeEmployee)new PolyMorphism_OverRiding.Employee(); //not binding

            ///animal = dog;
            ///animal = cat;
            ///dog =(dog) animal; 
            #endregion

            #region why Binding
            ///class memeber method to process employees methods with all types of employees
            ///calling => showrole , printdetiaild

            //FullTimeEmployee fullTime = new FullTimeEmployee();
            //PartTimeEmployee partTime = new PartTimeEmployee();
            //FreeLanceEmployee freeLance = new FreeLanceEmployee();
            //DayFullTimeEmployee dayFullTime = new DayFullTimeEmployee();
            //NightFullTimeEmployee nightFullTime = new NightFullTimeEmployee();

            //ProcessEmployee(fullTime);
            //ProcessEmployee(partTime);
            //ProcessEmployee(freeLance);
            //ProcessEmployee(dayFullTime);
            //ProcessEmployee(nightFullTime);


            //FullTimeEmployee fullTime01 = new NightFullTimeEmployee();
            //fullTime01.ShowRole();
            //fullTime01.PrintDetails();

            //ProcessEmployee(fullTime01);

            #endregion

            #region More Practise on Binding
            //TypeA typeA = new TypeC(1, 2, 3);
            //typeA.A = 10;
            ////typeA.B = 10; 
            ////typeA.C = 10;

            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeC(1,2,3);
            //typeB.A = 10;
            //typeB.B = 10; 
            ////typeB.C = 10;

            //typeB.MyFun01();
            //typeB.MyFun02();


            //TypeA typeA1 = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB1 = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC1 = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD1 = new TypeD(1, 2, 3, 4);
            //TypeD typeD2 = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD3 = new TypeF(1, 2, 3, 4, 5);

            //typeA1.MyFun02(); //typeC
            //typeB1.MyFun02(); //typeC
            //typeC1.MyFun02(); //typeC
            //typeD1.MyFun02(); //typeD
            //typeD2.MyFun02(); //typeE
            //typeD3.MyFun02(); //typeD

            #endregion
            #endregion

            #region Interfeces
            #region Ex:01
            ////IMyType myType = new IMyType(); //not valid 
            ////IMyType myType = new MyType(); //=> binding
            //IMyType myType = new MyType(); //=> binding
            //myType.Salary = 20000;
            //myType.Myfun();
            //myType.Print();

            //MyType type = new MyType();
            //type.Salary = 20000;
            //type.Myfun();
            //type.Print(); //not valid 
            #endregion
            #region Ex:02
            ///class member method to print 10 number of series in one line 
            ///with tabs between numbers => (series , number)
            // seriesbytwo => 0 2 4 6 8 10 12
            // seriesbythree => 0 3 6 9 12 15
            // seriesbyfour => 0 4 8 12 16 20
            // seriesbyfive => 0 5 10 15 20 25
            // seriesbyseven

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //PrintNumbersFromSeries(20, seriesByTwo);

            //SeriesBySeven seriesBySeven = new SeriesBySeven();
            //PrintNumbersFromSeries(20, seriesBySeven);

            //SeriesByFive seriesByFive = new SeriesByFive();
            //PrintNumbersFromSeries(20, seriesByFive);
            #endregion
            #region Implment Interface Implicitly Vs Implment Interface Explicitly
            //Interfaces.Car car = new Interfaces.Car();
            //car.Speed = 20;
            //car.Forward();
            //car.Backward();
            //car.Left();
            //car.Right();

            //AirPlan airPlan = new AirPlan();
            //airPlan.Speed = 60;
            //Console.WriteLine("After Moving");
            //IMoveable moveablePlan = airPlan;
            //moveablePlan.Forward();
            //moveablePlan.Backward();
            //moveablePlan.Left();
            //moveablePlan.Right();
            //moveablePlan.Speed = 100;
            //Console.WriteLine("After Flying");
            //IFlyable flyablePlan = airPlan;
            //flyablePlan.Forward();
            //flyablePlan.Left();
            //flyablePlan.Right();
            //flyablePlan.Speed = 600;

            #endregion
            #region Shallow Copy Vs Deep Copy
            //int x = 10;
            //int y = 20;
            //y = x;
            //y = 30;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");
            #region Shallow copy
            //Arr02 = Arr01;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 99;
            //Console.WriteLine(Arr01[0]);

            #endregion
            #region Deep Copy
            ////int x =(int) new object(); //unboxing
            //Arr02 = (int[]) Arr01.Clone();
            //Console.WriteLine("After Deep Copy");
            //foreach (int item in Arr02)
            //{
            //    Console.Write($"{item} \t");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");
            //Arr02[0] = 99;
            //Console.WriteLine(Arr01[0]);
            #endregion
            #endregion
            #region Built-In Interface ICloneable
            //Interfaces.Employee emp01 = new Interfaces.Employee();
            //emp01.Id = 10;
            //emp01.Name = "Ahmed";
            //emp01.Salary = 10000;
            //emp01.Address = "cairo";

            //Interfaces.Employee emp02 = new Interfaces.Employee()
            //{
            //    Id = 30,
            //    Name = "omr",
            //    Salary = 15000,
            //    Address = "cairo"
            //};

            //Console.WriteLine($"Emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"Emp02 : {emp02.GetHashCode()}");

            //emp02 = Interfaces.Employee.DeepCopy(emp01); //=> copy object not reference

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"Emp02 : {emp02.GetHashCode()}");

            //Console.WriteLine(emp01);
            //Console.WriteLine(emp02);

            //emp02.Id = 100;
            //Console.WriteLine(emp01.Id);

            //Interfaces.Car[] cars = new Interfaces.Car[5];
            //Interfaces.Employee[] employees = new Interfaces.Employee[5];
            //deepycopyArray(cars);
            //deepycopyArray(employees);
            #endregion
            #region Built-In Interface IComparable
            //int[] arr = { 9, 8, 11, 7, 2, 3, 4, 5, 1 };
            ////Array.Sort(arr);


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length - i - 1; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //            Swap(ref arr[j], ref arr[j + 1]);
            //    }
            //}

            //foreach (int item in arr)
            //{
            //    Console.Write($"{item} \t");
            //}
            //Console.WriteLine();


            //string[] strings = { "omr", "ahmed", "ali" };
            ////Array.Sort(strings);


            //for (int i = 0; i < strings.Length; i++)
            //{
            //    for (int j = 0; j < strings.Length - i - 1; j++)
            //    {
            //        if (strings[j].CompareTo(strings[j + 1]) > 0)
            //            Swap(ref strings[j], ref strings[j + 1]);
            //    }
            //}

            //foreach (string item in strings)
            //{
            //    Console.Write($"{item} \t");
            //}
            //Console.WriteLine();


            //Interfaces.Employee[] employees =
            //{
            //    new Interfaces.Employee() { Id = 10 , Name = "Ahmed" , Address = "Cairo", Salary = 10_000},
            //    new Interfaces.Employee() { Id = 20 , Name = "Ali" , Address = "Alex", Salary = 4_000},
            //    new Interfaces.Employee() { Id = 30 , Name = "Omar" , Address = "Asyut", Salary = 8_000},
            //    new Interfaces.Employee() { Id = 40 , Name = "Amr" , Address = "Fayoum", Salary = 5_000},
            //};

            ////Array.Sort(employees);


            //for (int i = 0; i < employees.Length; i++)
            //{
            //    for (int j = 0; j < employees.Length - i - 1; j++)
            //    {
            //        if (employees[j].CompareTo(employees[j + 1]) > 0)
            //            Swap(ref employees[j], ref employees[j + 1]);
            //    }
            //}

            //foreach (Interfaces.Employee item in employees)
            //{
            //    Console.Write($"{item} \t");
            //}
            //Console.WriteLine();
            #endregion
            #endregion

            #region Abstract
            ////BaseShape shape = new BaseShape(); //not valid

            ////Squere squere = new Squere();
            //Squere squere = new Squere(10);
            ////squere.Side = 20; //not valid

            //squere = new Squere(0);
            //Console.WriteLine(squere.Perimeter);
            //Console.WriteLine(squere.Area);

            //Rectangle rectangle = new Rectangle(20,10);
            ////rectangle.Width = 20; rectangle.Height = 10;
            //Console.WriteLine(rectangle.Perimeter);
            //Console.WriteLine(rectangle.Area);

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            ////seriesByTwo.Current = 20; //not valid in => private protected
            ////seriesByTwo.Current = 20; //not valid in => protected
            ////seriesByTwo.Current = 20; //not valid in => protected internal
            #endregion

            #region Operator Overloading
            //Complex c1 = new Complex(1, 2);
            //Complex c2 = new Complex(3, 4);
            //Complex c3 = new Complex(5, 6);
            //Complex c5 = default;

            //Complex c4 = c1 + c2 + c3 + c5;
            //Console.WriteLine(c4);

            //Console.WriteLine(c1++); //print => 1+2i then value => 2+3i
            //Console.WriteLine(++c1); //value => 3+4i then print => 3+4i
            //Console.WriteLine(c1--); //print => 3+4i then value => 2+3i
            //Console.WriteLine(--c1); //value => 1+2i then print => 1+2i
            //Console.WriteLine(c1);   //print => 1+2i


            #region Equals and GetHashcode
            //int x = 10;
            //int y = 10;
            //Console.WriteLine(x.GetHashCode());
            //Console.WriteLine(y.GetHashCode());

            //if(x.Equals(y))
            //    Console.WriteLine("equals");
            //else
            //    Console.WriteLine("not equals");


            //Complex c1 = new Complex(1, 2);
            //Complex c2 = new Complex(1, 2);

            //Console.WriteLine(c1.GetHashCode());
            //Console.WriteLine(c2.GetHashCode());

            ////default => compare hashcode == hashcode
            //if (c1 == c2)
            //    Console.WriteLine("equal");
            //else
            //    Console.WriteLine("not equal");


            //HashSet<Complex> complexes = new HashSet<Complex>();
            //complexes.Add(c1);
            //complexes.Add(c2);
            //Console.WriteLine(complexes.Count);

            //if (c1.Equals(c2))
            //    Console.WriteLine("equal");
            //else
            //    Console.WriteLine("not equal");


            ///obj1.gethashcode == obj1.gethashcode  => true
            ///obj1.equals(obj2) == true

            /// any tow equals object must have same hashcode
            /// but if two object has same hashcode my be equals or not

            //string x = "ahmed"; //string x = new string("ahmed");
            //string y = "ahmed"; //string y = new string("ahmed");

            //if (x == y)
            //    Console.WriteLine("equal");
            //else
            //    Console.WriteLine("not equal");


            //if (x.Equals(y))
            //    Console.WriteLine("equal");
            //else
            //    Console.WriteLine("not equal");

            //Console.WriteLine(x.GetHashCode());
            //Console.WriteLine(y.GetHashCode());



            #endregion
            #endregion

            #region User-Defined Casting Operator
            //OperatorOverLoading.Employee emp = new OperatorOverLoading.Employee()
            //{
            //    Id = 102030,
            //    FirstName = "Ahmed",
            //    LastName = "Mohmed",
            //    BirthDate = new DateOnly(2000, 03, 15),
            //    Salary = 10_000,
            //    Address = new Address() { AddressDetails = "el galaa street", City = "cairo", Country = "egypt" }
            //};

            #region Deep Copy, equals and gethashcode example 
            //OperatorOverLoading.Employee emp01 = emp;

            //OperatorOverLoading.Employee emp02 = (OperatorOverLoading.Employee)emp.Clone();
            //emp02.Id = 20;
            //emp02.Address.City = "Banha";

            //Console.WriteLine(emp.Id);
            //Console.WriteLine(emp.Address.City);

            //if (emp.Equals(emp02))
            //    Console.WriteLine("equals");
            //else
            //    Console.WriteLine("not equals");

            //if (emp == emp02)
            //    Console.WriteLine("equals");
            //else
            //    Console.WriteLine("not equals");

            //Console.WriteLine(emp.GetHashCode());
            //Console.WriteLine(emp02.GetHashCode()); 
            #endregion

            //EmployeeViewModel empview = new EmployeeViewModel()
            //{
            //    FullName = $"{emp.FirstName} {emp.LastName}",
            //    Age = DateTime.Now.Year - emp.BirthDate.Year,
            //    Address = $"{emp.Address.AddressDetails}, {emp.Address.City}, {emp.Address.Country}",
            //    NetSalary = emp.Salary - emp.Detuctions
            //};

            //EmployeeViewModel empview01 = new EmployeeViewModel(emp);
            //Console.WriteLine(empview01);

            ////EmployeeViewModel empview02 = emp; //implicit cast not recommended => readiblity
            ////Console.WriteLine(empview02);

            //EmployeeViewModel empview03 = (EmployeeViewModel)emp; //Explicit recommended => readiblity
            //Console.WriteLine(empview03);

            //EmployeeViewModel empview04 = emp.ToEmployeeViewModel(); //Extintion method
            //Console.WriteLine(empview04);

            //EmployeeViewModel empview05 = EmployeeExtintions.ToEmployeeViewModel(emp); //Static method
            //Console.WriteLine(empview05);


            //int x = 10;
            //double y = 10.25;
            //y = x; //implicit casting
            //x.Add(2);
            //Extintions.Add(x, 2);

            #endregion

            #region Static
            //Console.WriteLine(Utility.PI);
            //Console.WriteLine(Utility.CalculateCircleArea(10));
            #endregion

            #region Sealed
            //GrandChild grandChild = new GrandChild();
            //grandChild.Salary = 10_000;
            //grandChild.Print();

            //Console.WriteLine(grandChild.Salary);


            //Sealed.Child  child = grandChild;
            //Console.WriteLine(child.Salary);
            //child.Print();
            #endregion

            ///genircs
            #region Generics
            #region Ex01:Swap
            #region NonGenerics
            //int num1 = 10, num2 = 20;
            //object obj1 = num1, obj2 = num2; //boxing => value type => reference type
            ////Helper.Swap(ref num1, ref  num2); //boxing => value type => reference type
            //Helper.Swap(ref obj1, ref obj2); //boxing => value type => reference type
            //num1 = (int)obj1; //unboxing => reference type => value type
            //num2 = (int)obj2; //unboxing => reference type => value type
            //Console.WriteLine($"num1 : {num1}, num2 : {num2}");


            //double num3 = 10.5, num4 = 20.5;
            //object obj3 = num3, obj4 = num4; //boxing => value type => reference type
            ////Helper.Swap(ref num3, ref num4);
            //Helper.Swap(ref obj3, ref obj4);
            //num3 = (double)obj3; //unboxing => reference type => value type
            //num4 = (double)obj4; //unboxing => reference type => value type
            //Console.WriteLine($"num3 : {num3}, num4 : {num4}");

            //string str1 = "ahmed", str2 = "ali";
            //object obj5 = str1, obj6 = str2;
            //Helper.Swap(ref obj5, ref obj6);
            ////Helper.Swap(ref str1, ref str2);
            //str1 = (string)obj5;
            //str2 = (string)obj6;
            //Console.WriteLine($"str1 : {str1}, str2 : {str2}");   
            #endregion
            #region Generics
            //int num1 = 10, num2 = 20;
            //Helper.Swap<int>(ref num1, ref num2);
            //Console.WriteLine($"num1 : {num1}, num2 : {num2}");


            //string str1 = "Ahmed", str2 = "Mohmed";
            ////Helper.Swap<string>(ref str1, ref str2);
            //Helper.Swap(ref str1, ref str2);
            //Console.WriteLine($"str1 : {str1}, str2 : {str2}");

            ///not valid => because T is int and U is double
            //int num5 = 10;
            //double num6 = 20.5;
            //Helper.Swap<int, double>(ref num5, ref num6);
            #endregion
            #endregion
            #region Ex02: SearchArray 
            ////int[] numbers = { 5, 3, 2, 19, 4, 10, 1, 4 };
            ////int Postion = Array.IndexOf(numbers, 4);
            ////int Postion2 = Helper.SearchArray(numbers, 4);
            ////Console.WriteLine(Postion);
            ////Console.WriteLine(Postion2);

            //Generics.Point[] points =
            //{ 
            //    new Generics.Point(1, 2),
            //    new Generics.Point(3, 4),
            //    new Generics.Point(5, 6),
            //    new Generics.Point(7, 8)
            //};

            ////Generics.Point pointToFind = new Generics.Point(5, 6);

            ////Console.WriteLine(pointToFind.GetHashCode());
            ////Console.WriteLine(points[2].GetHashCode());

            ////if(pointToFind.Equals(points[2]))
            ////{
            ////    Console.WriteLine("Equals");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Not Equals");
            ////}

            //int Postion3 = Array.IndexOf(points, new Generics.Point(5, 6));
            //int Postion4 = Helper.SearchArray(points, new Generics.Point(5, 6));
            //Console.WriteLine(Postion3);
            //Console.WriteLine(Postion4);

            #endregion
            #region Ex03: GetMax
            //////Quiz
            //Generics.Point[] points =
            //{
            //    new Generics.Point(1, 2),
            //    new Generics.Point(3, 4),
            //    new Generics.Point(5, 6),
            //    new Generics.Point(7, 8)
            //};
            //Generics.Point Max = Helper.GetMax(points);


            //int[] numbers = { 5, 3, 2, 19, 4, 10, 1, 4 };
            //int max = Helper.GetMax(numbers);
            #endregion

            #endregion
            #endregion

            #region Delegate
            #region EX:01
            //////Delegate Is a C# Language Feature
            //////has 2 Usages:-
            ////// 1. functional programming [stratigay design pattern] => (pass function as parameter, return function, can save function into variable[address of function])
            ////// 2. Event-Driven Programming [observer design pattern]

            //////step 1. Declare ref From Delegate
            //StringFuncDelegate reference;

            //////step 2. intial the delegate reference [pointer of function]
            ////reference = new StringFuncDelegate(StringFunction.GetCountOfUpperCaseChar);
            //reference = StringFunction.GetCountOfUpperCaseChar; // syntax sugger
            //reference += StringFunction.GetCountOfUpperCaseChar;
            //reference += StringFunction.GetCountOfLowerCaseChar;
            //reference -= StringFunction.GetCountOfUpperCaseChar;
            //reference -= StringFunction.GetCountOfUpperCaseChar;
            //reference -= StringFunction.GetCountOfUpperCaseChar;
            //reference -= StringFunction.GetCountOfLowerCaseChar;


            //////step 3. use the Delegate Reference
            //int res = reference?.Invoke("Ahmed Ali") ?? 0;
            ////int res02 = reference("Ahmed Ali");

            //Console.WriteLine(res); 
            #endregion
            #region Ex:02
            //double[] numbers = { 8, 2, 7, 10, 7, 3, 5, 1, 4, 6 };
            //SortingAlgorithm.BubbleSortingWithType(numbers, SortingTypes.SortAsc);
            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item}\t");
            //}
            //Console.WriteLine();

            //SortingAlgorithm.BubbleSortingWithType(numbers, SortingTypes.SortDesc);

            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item}\t");
            //}
            //Console.WriteLine();


            //string[] Names = { "Ali", "Mahmoud", "Omar", "Ahmed" };
            //SortingAlgorithm.BubbleSortingWithType<string>(Names, SortingTypes.SortDesc);
            #endregion
            #region Ex:03
            ////List<int> numbers = new List<int> { 7, 8, 10, 11, 12 };
            ////ArrayList arrayList = new ArrayList { "Ahmed", 15, 12.25 };

            //List<int> numbers = Enumerable.Range(0, 100).ToList();
            //List<int> OddNumbers = NumberFinding.FindNumbers<int>(numbers, (GenericsNumberFindingFuncDelegate<int>)NumberConditions.IsOdd);
            //List<int> EvenNumbers = NumberFinding.FindNumbers(numbers, (GenericsNumberFindingFuncDelegate<int>)NumberConditions.IsEven);
            //List<int> BySevenNumbers = NumberFinding.FindNumbers(numbers, (NumberFindingFuncDelegate)NumberConditions.IsDivisibleBySeven);



            //List<string> Names = new List<string>() { "Ali", "Mahmoud", "Omar", "Ahmed" };
            //List<string> strings = NumberFinding.FindNumbers(Names, (EnhanceGenericsNumberFindingFuncDelegate<string, bool>)NumberConditions.CheckLength);
            #endregion
            #region BuiltIn Delegates [Predicate,func,action]
            //delegete is c# language feature use to apply features in functional programing
            //there are 3 built in delegete :

            //1.Predicate  => takes one input parameter and returns a boolean - true or false.is a special kind of Func. It represents a method that contains a set of criteria mostly defined inside an if condition and checks whether the passed parameter meets those criteria or not.

            //2.Action     => takes zero, one or more input parameters, but does not return anything.

            //3.Func       => takes zero, one or more input parameters, and returns a value (with its out parameter)

            #region Example - 01 => BuiltIn Predicate in NumberFinding Class 
            //List<int> Numbers = Enumerable.Range(0, 100).ToList();
            //Predicate<int> numberDelegate = NumberConditions.IsOdd;
            //List<int> oddnumber = NumberFinding.FindNumbers(Numbers, numberDelegate);
            #endregion
            #region  Example - 02 => BuiltIn Func in SortingAlgorithm Class
            //string[] Names = { "Ali", "Mahmoud", "Omar", "Ahmed" };
            //Func<string, string, bool> Reference = SortingTypes.SortAsc;
            //SortingAlgorithm.BubbleSortingWithType(Names, Reference);
            #endregion
            #region Example - 03 => BuiltIn Action
            //Action action;
            //action = SomeFunction.Print;
            //action();


            //Action<string> action01;
            //action01 = SomeFunction.Print;
            //action01("ali");
            #endregion
            #endregion
            #region Anonymous Function
            // Anonymous Function : c# 2.0 Feature (.net framework 2.0 [2005])

            //Predicate<string> predicate;
            ////predicate = SomeFunction.test;
            ////Console.WriteLine(predicate("Ahmed"));
            ////predicate = /*public*/ /*static*/ /*bool*/ /*test*/ delegate (string str) { return str.Length > 1; };
            //predicate = delegate (string str) { return str.Length > 1; };
            //predicate("ali");


            ////Action action;
            ////action = SomeFunction.Print;
            ////action();
            ////action = /*public*/ /*static*/ /*void*/ /*Print*/ delegate () { Console.WriteLine("hello"); };
            ////action = delegate () { Console.WriteLine("hello"); };

            //Action action = delegate () { Console.WriteLine("hello"); };
            //action();


            //Action<string> action1 = delegate (string str) { Console.WriteLine($"hello {str}"); };

            //Func<int, string> func = delegate (int str) { return str.ToString(); };
            #endregion
            #region Lambda Experssion
            // Lambda Expression : c# 3.0 Feature (.net framework 3.5 [2007])
            // => : this called as 'FatArrow' and Read as 'GoesTo'

            //Predicate<string> predicate;
            ////predicate = delegate (string str) { return str.Length > 1; };
            ////predicate = /*delegate (string*/ str/*)*/ => /*{ return*/ str.Length > 1; /*};*/
            //predicate = str => str.Length > 1;
            //predicate("ali");

            ////Action action = delegate () { Console.WriteLine("hello"); };
            ////Action action = /*delegate*/ () => /*{ */Console.WriteLine("hello"); /*};*/
            //Action action = () => Console.WriteLine("hello");
            //action();

            ////Action<string> action1 = delegate (string str) { Console.WriteLine($"hello {str}"); };
            //Action<string> action1 = str => Console.WriteLine($"hello {str}");

            ////Func<int, string> func = delegate (int str) { return str.ToString(); };
            //Func<int, string> func = str => str.ToString();
            #endregion
            #region New Feature in Delegate using "var" keyWord in c# 10.0 (.net 6)
            //var keyword => implicitly typed local variable [C# 2.0] => know it's type form it's intial value
            //var x = "ahmed";
            //x = 10; //not valid
            //var x; //not valid

            // in c# 10.0 Feature (.net 6) we can use [var] as delegate but [var] is from c# 2.0
            //var hamada = (string str) => str.Length > 1;
            //var hamada01 = (int str) => str.ToString();
            //var hamada02 = () => Console.WriteLine("hello");
            //var hamada03 = (string str) => Console.WriteLine($"hello {str}");
            #endregion
            #region List Methods that use delegate
            //List<int> Numbers = Enumerable.Range(0, 10).ToList();
            ////List<int> oddnumbers = NumberFinding.FindNumbers(Numbers,(NumberFindingFuncDelegate) NumberConditions.IsOdd);

            //List<int> oddnumbers = Numbers.FindAll(n => n % 2 == 1);
            //foreach (int item in oddnumbers)
            //{
            //    Console.Write($"{item}\t");
            //}
            //Console.WriteLine();

            //int firstodd = Numbers.Find(n => n % 2 == 1);
            //Console.WriteLine(firstodd);

            //int lastodd = Numbers.FindLast(n => n % 2 == 1);
            //Console.WriteLine(lastodd);

            //bool exists = Numbers.Exists(n => n % 7 == 0);
            //Console.WriteLine(exists);

            //bool trueforall = Numbers.TrueForAll(n => n % 2 == 0);
            //Console.WriteLine(trueforall);
            #endregion
            #region Method return Method
            //DelegateDoAction()();
            //DelegateDoAction().Invoke();
            //var x = DelegateDoAction();
            //x();
            #endregion
            #endregion

            ///event
            #region Event-Driven Programming
            // 2. Event-Driven Programming [observer design pattern]
            #region example
            ///hase football game with Ball, Player, and Refree
            /// Ball has location 
            /// player run when ball locatin changed
            /// refree look when ball location chang

            ///design: UML Digrams as (Class digram, sequance digram, ERD digram)

            ///default solution
            ///ball has: 
            ///1.full property location : get and in set check if new value not equal old location and if new fire players.run() method and refrees.look() method
            ///2.list of Players
            ///3.list of Refrees

            ///defecties:
            ///when we need to add list of Person we must change in ball class to add new list and change in set of location property to fire person.clap() method of person class
            ///that make our code not maintainable and not applay [open closed principle] 

            ///solution:
            /// 1.
            ///in [observer design pattern] => we will add only one list of (Isubscriber) 
            ///and create interface of it or abstract class 
            ///and every entity will subscribe (ball class) must inherit from it

            /// 2.
            ///in [Event] => add event to ball class [balllocationchanged] => has invokation list
            ///spicfay the type of function that subscribe with it [Delegate]
            ///fire event when ball location changed in setter
            #endregion

            Ball ball = new Ball();
            Console.WriteLine(ball.Location);

            Player p11 = new Player("P1", "T1");
            Player p12 = new Player("P2", "T1");

            Player p21 = new Player("P1", "T2");
            Player p22 = new Player("P2", "T2");

            Refree refree = new Refree("Refree01");

            ball.LocationChanged += p11.Run;
            ball.LocationChanged += p12.Run;
            ball.LocationChanged += p21.Run;
            ball.LocationChanged += p22.Run;

            ball.LocationChanged += refree.Look;

            //ball.LocationChanged = refree.Look;//not valid in event

            Console.WriteLine("Match is Started");
            ball.Location = new Location(10, 20, 30);

            Console.WriteLine($"{p21} is fired!");
            ball.LocationChanged -= p21.Run;

            ball.Location = new Location(20, 30, 40);

            //ball.LocationChanged(new Location(10, 20, 30)); //not valid
            #endregion
            ///EF
        }

        #region OOP
        #region PolyMorphism OverLoading
        ///1. datatype of parameters
        ///2. count number of parameters
        ///3. reorder parameters if not same datatype

        #region Ex :01
        static int Sum(int x, int y)
        {
            return x + y;
        }

        //static long Sum(int x, int y) //not overloading
        //{
        //    return x + y;
        //}

        static int Sum(short x, int y)
        {
            return x + y;
        }

        static int Sum(int y, short x)
        {
            return x + y;
        }

        static double Sum(double x, double y)
        {
            return x + y;
        }
        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        #endregion
        #region Ex : 02
        static decimal CalculateTotal(decimal price, int quntity)
        {
            return price * quntity;
        }
        static decimal CalculateTotal(decimal price, int quntity, decimal discount)
        {
            return (price * quntity) - discount;
        }
        static decimal CalculateTotal(decimal price, int quntity, decimal discount, decimal Tax)
        {
            return ((price * quntity) - discount) + Tax;
        }
        #endregion

        #endregion

        #region Binding
        public static void ProcessEmployee(PolyMorphism_OverRiding.Employee emp)
        {
            emp.ShowRole();
            emp.PrintDetails();
        }

        //public static void ProcessEmployee(FullTimeEmployee emp)
        //{
        //    emp.ShowRole();
        //    emp.PrintDetails();
        //}

        //public static void ProcessEmployee(PartTimeEmployee emp)
        //{
        //    emp.ShowRole();
        //    emp.PrintDetails();
        //}

        //public static void ProcessEmployee(FreeLanceEmployee emp)
        //{
        //    emp.ShowRole();
        //    emp.PrintDetails();
        //}
        #endregion

        #region Interface
        public static void PrintNumbersFromSeries(int number, ISeries series)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(series.Current);
                Console.Write("\t");
                series.GetNext();
            }
            Console.WriteLine();
            series.Reset();
        }

        //public static void PrintNumbersFromSeries(int number , SeriesByTwo series)
        //{
        //    for (int i = 0; i < number; i++)
        //    {
        //        Console.Write(series.Current);
        //        Console.Write("\t");
        //        series.GetNext();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //public static void PrintNumbersFromSeries(int number, SeriesByThree series)
        //{
        //    for (int i = 0; i < number; i++)
        //    {
        //        Console.Write(series.Current);
        //        Console.Write("\t");
        //        series.GetNext();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //public static void PrintNumbersFromSeries(int number, SeriesBySeven series)
        //{
        //    for (int i = 0; i < number; i++)
        //    {
        //        Console.Write(series.Current);
        //        Console.Write("\t");
        //        series.GetNext();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //public static void deepycopyArray(ICloneable[] oldcloneables) 
        //{
        //    //ICloneable[] cloneables; //= //new object[oldcloneables.Length];
        //    foreach (ICloneable item in oldcloneables)
        //    {
        //        object obj = item.Clone();
        //    }
        //}

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref Interfaces.Employee a, ref Interfaces.Employee b)
        {
            Interfaces.Employee temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref IComparable a, ref IComparable b)
        {
            IComparable temp = a;
            a = b;
            b = temp;
        }

        //public static void Sorting(object[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (arr[j].CompareTo(arr[j + 1]) > 0)
        //                Swap(ref arr[j], ref arr[j + 1]);
        //        }
        //    }
        //}

        public static void Sorting(IComparable[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                        Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
        #endregion
        #endregion

        #region Delegates
        //public static Action DelegateDoAction()
        //{
        //    return () => Console.WriteLine("hello");
        //}
        #endregion
    }
}
