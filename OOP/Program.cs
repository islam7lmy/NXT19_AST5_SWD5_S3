using Comman;
using OOP.Abstraction;
using OOP.Inhertiance;
using OOP.Interfaces;
using OOP.OperatorOverLoading;
using OOP.PolyMorphism_OverRiding;
using System.Runtime.InteropServices;
//using FirstCode;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            #endregion

            #region User-Defined Casting Operator
            #endregion
        }

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
    }
}
