using System.Text;

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
            //string x = "hello"; //syntactic sugar for string x = new string("hello");
            //Console.WriteLine(x.GetHashCode());
            //x = "world"; //x = new string("world"); 
            ////x is now referring to a new string object in memory,
            ////the old string "hello" is now eligible for garbage collection
            ////string is immutable => once created, it cannot be changed
            //Console.WriteLine(x.GetHashCode());
            //x += "!!!"; //x = x + "!!!"; //x = new string("world!!!");
            //Console.WriteLine(x.GetHashCode());
            ///////////////////////////////////////////////////////////////////////////
            //StringBuilder Y = new StringBuilder("hello");
            ////Console.WriteLine(Y.GetHashCode());
            //Y.Append(" world"); //modifies the existing StringBuilder object, rather than creating a new one
            ////Console.WriteLine(Y.GetHashCode());
            //Y.Clear(); //clears the content of the StringBuilder object, but does not change its reference
            //Y.AppendLine("new content"); //appends a new line to the StringBuilder object
            //Y.Insert(0, "hello world"); //inserts "hello world" at the beginning of the StringBuilder object
            //Y.Remove(0, "hello world".Length); //removes "hello world" from the beginning of the StringBuilder object
            //Y.Replace("new content", "replaced content"); //replaces "new content" with "replaced content" in the StringBuilder object
            //Console.WriteLine(Y);
            #endregion

            #region string formating
            // Equition : 4 + 2 = 6
            //int X = 4, Y = 2;
            //string result = "Equition : " + X + " + " + Y + " = " + (X + Y); //string concatenation

            //string result1 = "Equition : ";
            //result1 += X;
            //result1 += " + ";
            //result1 += Y;
            //result1 += " = ";
            //result1 += (X + Y);

            //StringBuilder result2 = new StringBuilder("Equition : ");
            //result2.Append(X);
            //result2.Append(" + ");
            //result2.Append(Y);
            //result2.Append(" = ");
            //result2.Append(X + Y);

            //string result3 = string.Format("Equition : {0} + {1} = {2}", X, Y, X + Y); //string formatting => Placeholder based formatting 

            //string result4 = $"Equition : {X} + {Y} = {X + Y}"; // string interpolation => Expression based formatting

            //string result5 = $"Equition : {X} + {Y} = {X + Y}" + $" the result is true";

            //result5 = new string($"Equition : {X} + {Y} = {X + Y}");
            //result5 += $" the result is true";

            //Console.WriteLine(result);
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);
            #endregion

            #region Conditional statment
            //if (condition) //true or false
            //{
            //    //statements to execute if condition is true
            //}
            //else if(condition2)
            //{
            //    //statements to execute if condition2 is true
            //}
            //else
            //{
            //    //statements to execute if all conditions are false
            //}


            ///jump table
            //varible = value;
            //switch (varible)
            //{ 
            //    case value1:
            //        //statements to execute if varible == value1
            //        break;
            //    case value2:
            //        //statements to execute if varible == value2
            //        break;
            //    case value3:
            //        //statements to execute if varible == value3
            //        break;
            //    default:
            //        //statements to execute if varible does not match any case
            //        break;
            //}

            #region Ex01 :write a program to take number in first quarter in year and print the month name 
            #region If statment
            ///write a program to take number in first quarter in year and print the month name 
            /// {1 , 2 , 3} => {january , February , March} 
            /// protictive code
            //Console.WriteLine("insert number of month in first qurter of year :");
            //int month = int.Parse(Console.ReadLine());
            //if (int.TryParse(Console.ReadLine(), out int month))
            //{
            //    if (month == 1)
            //    {
            //        Console.WriteLine("January");
            //    }
            //    else if (month == 2)
            //    {
            //        Console.WriteLine("February");
            //    }
            //    else if (month == 3)
            //    {
            //        Console.WriteLine("March");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid month number");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            //if (!int.TryParse(Console.ReadLine(), out int month))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return; // Exit the program or handle the error as needed
            //}

            //if (month == 1)
            //{
            //    Console.WriteLine("January");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine("February");
            //}
            //else if (month == 3)
            //{
            //    Console.WriteLine("March");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid month number");
            //}


            //if (!int.TryParse(Console.ReadLine(), out int month))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return; // Exit the program or handle the error as needed
            //}

            //Console.WriteLine(
            //    month == 1 ? "January" :
            //    month == 2 ? "February" :
            //    month == 3 ? "March" :
            //    "Invalid month number"
            //    ); 
            #endregion

            #region Switch statment
            //Console.WriteLine("insert number of month in first qurter of year :");
            //if (!int.TryParse(Console.ReadLine(), out int month))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return; // Exit the program or handle the error as needed
            //}

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;
            //} 
            #endregion
            #endregion

            #region Ex02
            //int salary = 3000;
            //switch(salary)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        //Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        //break;
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        //break;
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;
            //    default:
            //        Console.WriteLine("No Option");
            //        break;
            //}
            #endregion

            #region Calculater
            //take number then opertation then number and show result
            //calculater do (+ - * / %)
            //write program to do that and make it protictive
            #region not clean code
            //Console.WriteLine("Enter first number:");
            //if (int.TryParse(Console.ReadLine(), out int num1))
            //{
            //    if (char.TryParse(Console.ReadLine(), out char operation))
            //    {
            //        if (int.TryParse(Console.ReadLine(), out int num2))
            //        {
            //            int result = 0;
            //            switch (operation)
            //            {
            //                case '+':
            //                    result = num1 + num2;
            //                    break;
            //                case '-':
            //                    result = num1 - num2;
            //                    break;
            //                case '*':
            //                    result = num1 * num2;
            //                    break;
            //                case '/':
            //                    if (num2 != 0)
            //                    {
            //                        result = num1 / num2;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Error: Division by zero is not allowed.");
            //                    }
            //                    break;
            //                case '%':
            //                    if (num2 != 0)
            //                    {
            //                        result = num1 % num2;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Error: Modules by zero is not allowed.");
            //                    }
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /, %).");
            //                    break;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid integer.");
            //            return; // Exit the program or handle the error as needed
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid operator.");
            //        return; // Exit the program or handle the error as needed
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return; // Exit the program or handle the error as needed
            //} 
            #endregion

            #region clean code
            //Console.WriteLine("Enter first number:");
            //if (!int.TryParse(Console.ReadLine(), out int num1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return; // Exit the program or handle the error as needed
            //}

            //Console.WriteLine("Enter operation:");
            //if (!char.TryParse(Console.ReadLine(), out char operation)
            //    || (operation != '+' && operation != '-' && operation != '*' 
            //    && operation != '/' && operation != '%'))

            //{
            //    Console.WriteLine("Invalid input. Please enter a valid operator.");
            //    return; // Exit the program or handle the error as needed
            //}

            //Console.WriteLine("Enter seconed number:");
            //if (!int.TryParse(Console.ReadLine(), out int num2))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return; // Exit the program or handle the error as needed
            //}


            //int result = 0;
            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //            return; // Exit the program or handle the error as needed
            //        }
            //        result = num1 / num2;
            //        break;
            //    case '%':
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Error: Modules by zero is not allowed.");
            //            return; // Exit the program or handle the error as needed
            //        }
            //        result = num1 % num2;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /, %).");
            //        break;
            //}
            //Console.WriteLine($"{num1} {operation} {num2} = {result}");
            #endregion

            #endregion
            #endregion

            #region Loop statments
            // 10 steps to print 1 to 10
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            #region For
            // start => i = 1
            // condition => i <= 10 => true
            // execute => Console.WriteLine(i);
            // increment => i++
            // repeat => condition => i <= 10 => true
            // repeat => execute => Console.WriteLine(i);
            // repeat => increment => i++

            //for (int i = 1; i <= 10; i++) // ++i
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1; //start
            //for(; ; i++)
            //{
            //    if (!(i <= 10)) //condition
            //        break; //exit loop

            //    if (i % 2 == 0)
            //    {
            //        continue; //skip even numbers
            //        //i++; //increment
            //    }
            //    Console.WriteLine(i); //execute

            //    //i++; //increment
            //}
            #endregion

            #region While
            //Console.WriteLine("insert 0 if you want to exist");
            //string input = Console.ReadLine();
            //while(input != "0")
            //{
            //    Console.WriteLine($"you entered : {input}");
            //    Console.WriteLine("insert 0 if you want to exist");
            //    input = Console.ReadLine();
            //}


            //Console.WriteLine("Enter first number:");
            //while (!int.TryParse(Console.ReadLine(), out int num1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            //[quiz] write calculater program using while loop and switch statment and make it protictive
            #endregion
            #endregion
        }

    }
}
