using Comman;
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

            PhoneBook book = new PhoneBook();
            //book.names = new string[5]; 
            //book.numbers = new string[10]; 

            Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");
            //book = new PhoneBook(15);
            //book.AddContact("ahmed", "01234567891", 0); //=> disable postion make it automatic [quiz]
            //book.AddContact("ahmed", "01234567123", 0); //=> reset
            //Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");
            //book.RemoveContact("ahmed");
            //Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");
            book.AddContact("ahmed", "01234567891", 0);
            //book.SetContact("ahmed", "01234567123");
            //Console.WriteLine(book.GetContact("ahmed"));


            book["ahmed"] = "01234567123"; //=> set number
            Console.WriteLine(book["ahmed"]);

           // Console.WriteLine(book[0]); // => [quiz]
            #endregion
            #endregion
        }
    }
}
