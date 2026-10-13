using Comman;
using OOP.Inhertiance;
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
            Console.WriteLine("***************************Struct**************************");
            PhoneBook book = new PhoneBook();
            book.AddContact("ahmed", "0000000000");


            PhoneBook book02 = book;

            //book02.AddContact("ahmed", "0000000000");
            //Console.WriteLine(book.GetContact("ahmed"));  ///0000000000

            //book02.names = new string[10];
            //book02.numbers = new string[10];
            //Console.WriteLine($"{book.names.Length} , {book.numbers.Length}"); // 2
            //Console.WriteLine($"{book02.names.Length} , {book02.numbers.Length}"); // 10

            book02 = new PhoneBook();
            Console.WriteLine(book["ahmed"]);
            Console.WriteLine(book02["ahmed"]);



            Console.WriteLine("***************************CLASS**************************");
            
            PhoneBookClass book03 = new PhoneBookClass();
            book03.AddContact("ahmed", "0000000000");


            PhoneBookClass book04 = book03;
            //book04.AddContact("ahmed", "0000000000");
            //Console.WriteLine(book03.GetContact("ahmed")); ///0000000000

            //book04.names = new string[10];
            //book04.numbers = new string[10];
            //Console.WriteLine($"{book03.names.Length} , {book03.numbers.Length}"); // 10

            book04 = new PhoneBookClass();
            Console.WriteLine(book03["ahmed"]);
            Console.WriteLine(book04["ahmed"]);

            #endregion
            #endregion

            #region PolyMorphism
            #region Overloading

            #endregion
            #region OverRiding

            #endregion
            #endregion

            #region Binding

            #endregion

            #region Interfeces

            #endregion
        }
    }
}
