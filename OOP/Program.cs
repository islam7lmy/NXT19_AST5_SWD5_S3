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
            Employee emp = new Employee();
            emp.Salary = 1000000000;
            Console.WriteLine(emp.Salary);
            #endregion
            #endregion
        }
    }
}
