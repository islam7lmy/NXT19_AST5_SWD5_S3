namespace Demo01
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Serves as the entry point for the application.
        /// </summary>
        /// <param name="args">An array of command-line arguments supplied to the application. Each element contains a single argument as a
        /// string. May be empty if no arguments are provided.</param>
        static void Main(string[] args)
        {
            #region Comment
            //line comment  

            /*
             * block comment
             * block comment
             * block comment
             */
            #endregion

            #region Value types
            //int X;
            /////allocate 4 uninitilized bytes in stack for X
            ////Console.WriteLine(X); //invalid

            //X = 5;

            //Int32 Y;
            /////allocate 4 uninitilized bytes in stack for Y

            //Y = 10;

            //Y = X;

            //X = X + 1;

            //Console.WriteLine($"X : {X}");
            //Console.WriteLine($"Y : {Y}");
            #endregion

            #region Reference Type
            //Point P1;
            /////allocate 4 bytes in stack for reference of type point [P1], referring to null
            /////zero bytes will be allocated in heap

            ////Console.WriteLine(P1.X);//invalid

            //P1 = new Point();
            /////new
            /////1.allocate required bytes in heap for Point object (4 bytes for X , 4 bytes for Y)
            /////2.initialize allocated bytes with default values of it's datatype
            /////3.call user-defined constructor if exists
            /////4.return address of allocated momory in heap to Caller(P1 = address of point object in heap)

            ////Console.WriteLine($"P1({P1.X},{P1.Y})");


            //Point P2 = new Point();

            //Console.WriteLine($"P1: {P1.GetHashCode()}");
            //Console.WriteLine($"P2: {P2.GetHashCode()}");

            //P2 = P1;

            //Console.WriteLine("after assignment");
            //Console.WriteLine($"P1: {P1.GetHashCode()}");
            //Console.WriteLine($"P2: {P2.GetHashCode()}");

            //P1.X = 5;


            //Console.WriteLine($"P2({P2.X},{P2.Y})");

            #endregion

            #region Fractions and Discards
            //int X = 1_000_000_000; //_ discard to improve readabilty

            //double d1 = 15.3;
            //float f1 = 15.3f;
            //decimal m1 = 15.3m;
            #endregion

            #region Value Type Casting
            /// 1. implicit casting (safe casting)
            //int X = 5;
            //long Y = X;
            //Y = 1_000_000_000_000;

            //X = Y; //invalid => compiler error => possible loss of data

            /// 2. explicit casting (unsafe casting)
            //X = (int)Y; //explicit casting => possible loss of data
            //Console.WriteLine($"Y : {Y}");
            //Console.WriteLine($"X : {X}");
            //checked
            //{
            //    int Z = (int)Y;
            //    unchecked
            //    {
            //        Console.WriteLine($"Z : {Z}");
            //    }
            //}

            /// 3. Parse (string to value type)
            //Console.Write("Please enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Please enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Hello {name}, your age is {age}");

            /// 4. TryParse (string to value type)
            //Console.Write("Please enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Please enter your age: ");
            ////int age = int.Parse(Console.ReadLine());
            //bool result = int.TryParse(Console.ReadLine(), out int age);
            //Console.WriteLine($"Hello {name}, your age is {age}");
            //Console.WriteLine($"age casted successfuly : {result}");

            /// 5. Convert (string to value type)
            //Console.Write("Please enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Please enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Hello {name}, your age is {age}");
            #endregion

            #region Operators

            #region Unary Operator
            //int X = 10;
            ////X++; //x = x + 1;
            ////++X; //x = x + 1;
            ////X--; //x = x - 1;
            ////--X; //x = x - 1;
            ///// Prefix [increment and then use the value]
            //Console.WriteLine(++X); ///increment X = 11 and then use the value 11
            ///// Postfix [use the value and then increment]
            //Console.WriteLine(X++); ///use the value 11 and then increment X = 12
            //Console.WriteLine(X);  ///use the value 12 

            ///// prefix decrement [decrement and then use the value]
            //Console.WriteLine(--X); //decrement X = 11 and then use the value 11
            ///// postfix decrement [use the value and then decrement]
            //Console.WriteLine(X--); //use the value 11 and then decrement X = 10
            //Console.WriteLine(X); //use the value 10
            #endregion

            #region Binary Operator
            //int Sum, Mul, Sub, Div, Mod, num1 = 10, num2 = 3;
            //Sum = num1 + num2;
            //Mul = num1 * num2;
            //Sub = num1 - num2;
            //Div = num1 / num2;
            //Mod = num1 % num2;

            //int X = 10 / 3; //3
            //double Y = 10 / 3; //3
            //Y = 10.0 / 3; //3.3333333333333335

            //Y = (double)num1 / num2; //3.3333333333333335
            #endregion

            #region Assignment Operator
            //int X;
            //X = 5; //assignment operator
            //X += 5; //X = X + 5;
            //X -= 5; //X = X - 5;
            //X *= 5; //X = X * 5;
            //X /= 5; //X = X / 5;
            //X %= 5; //X = X % 5;
            #endregion

            #region Relational Operator [Comparision]
            //int X = 10, Y = 20;
            //Console.WriteLine(X == Y); //equality operator => true if X is equal to Y
            //Console.WriteLine(X != Y); //inequality operator => true if X is not equal to Y
            //Console.WriteLine(X > Y); //greater than operator => true if X is greater than Y
            //Console.WriteLine(X < Y); //less than operator => true if X is less than Y
            //Console.WriteLine(X >= Y); //greater than or equal to operator => true if X is greater than or equal to Y
            //Console.WriteLine(X <= Y); //less than or equal to operator => true if X is less than or equal to Y
            #endregion

            #region Logical operator
            //Console.WriteLine(!false); //logical NOT operator => true if operand is false
            //Console.WriteLine(false && true); //short circuit //logical AND operator => true if both operands are true
            //Console.WriteLine(true || false); //short circuit //logical OR operator => true if either operand is true

            //Console.WriteLine(4 < 5 && 7 > 9 || 5 == 5);
            //Console.WriteLine((4 > 5) && (7 > 9 || 5 == 5));
            //Console.WriteLine((4 < 5) && !(7 > 9 || 5 == 5));
            #endregion

            #region Bitwise operator
            //Console.WriteLine(false & true); //long circuit //bitwise AND operator => true if both operands are true
            //Console.WriteLine(true | false); //long circuit //bitwise OR operator => true if either operand is true
            //Console.WriteLine(true ^ false); //bitwise XOR operator => true if operands are different
            #endregion

            #region Ternary Operator [Conditional operator]
            //int X = 4, Y = 7;
            //if(X > Y)
            //{
            //    Console.WriteLine("X is greater than Y");
            //}
            //else
            //{
            //    Console.WriteLine("Y is greater than X");
            //}
            //Console.WriteLine(X > Y ? "X is greater than Y" : "Y is greater than X");

            //int Z = 20;

            //if(X > Y)
            //    if(X > Z)
            //        Console.WriteLine("X is the greatest");
            //    else
            //        Console.WriteLine("Z is the greatest");
            //else
            //    if(Y > Z)
            //        Console.WriteLine("Y is the greatest");
            //    else
            //        Console.WriteLine("Z is the greatest");

            ///// not recommended to use nested ternary operator because it reduces code readability
            //Console.WriteLine(X > Y ? (X > Z ? "X is the greatest" : "Z is the greatest") : (Y > Z ? "Y is the greatest" : "Z is the greatest"));

            #endregion

            #region Operators Priorty
            /// 1. unary operator (prefix)
            /// 2. round brackets ()
            /// 3. Multiplictive operator (*,/,%)
            /// 4. additive operator (+,-)

            //int a = 20, b = 10, c = 15, d = 5;
            ////int result = a + b * c / d; //20 + 10 * 15 / 5 => 20 + 150 / 5 => 20 + 30 => 50 
            ////int result2 = (a + b) * c / d; // 30 * 15 / 5 => 450 / 5 => 90
            ////int result3 = ((a + b) * c) / d; // 30 * 15 / 5 => 450 / 5 => 90
            ////int result4 = --a + b * c / d; // 19 + 10 * 15 / 5 => 19 + 150 / 5 => 19 + 30 => 49
            ////int result5 = --a - a-- + ++a + a++ - --a + a--; 
            ///// value of a = 19 => 19 - a--  + ++a + a++ - --a + a-- 
            ///// value of a = 19 => 19 - 19 + ++a + a++ - --a + a-- => value of a = 18 
            ///// value of a = 19 => 19 - 19 + 19 + a++ - --a + a-- 
            ///// value of a = 19 => 19 - 19 + 19 + 19 - --a + a-- => value of a = 20
            ///// value of a = 19 => 19 - 19 + 19 + 19 - 19 + a-- 
            ///// value of a = 19 => 19 - 19 + 19 + 19 - 19 + 19 => value of a = 18
            ///// 19 - 19 + 19 + 19 - 19 + 19 => 38
            #endregion
            #endregion

            #region string vs stringbuilder

            #endregion
        }

    }
}
