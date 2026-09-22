using System.Collections;
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

            #region do while
            //Console.WriteLine("Enter first number:");
            //while (!int.TryParse(Console.ReadLine(), out int num1))
            //{
            //    Console.WriteLine("Enter first number:");
            //    //Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            //do
            //{
            //    Console.WriteLine("Enter first number:");
            //} while (!int.TryParse(Console.ReadLine(), out int num1));

            #endregion

            #region foreach
            //List<string> names = new List<string>()
            //{
            //    "ali",
            //    "ahmed",
            //    "sara"
            //};

            //for (int i = 0; i < names.Count; i++)
            //{
            //    names[i] = $"hello {names[i]}";
            //    Console.WriteLine(names[i]);
            //}

            ////for reading
            //foreach(string item in names)
            //{
            //    //item = $"hello {item}";
            //    Console.WriteLine(item);
            //}

            #endregion

            #region EX00
            //int num01, num02;
            //char op;
            //double result = 0;

            //Console.WriteLine("enter first number:");
            //while (!int.TryParse(Console.ReadLine(), out num01))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            //do
            //{
            //    Console.WriteLine("enter operator ( + - * / % )");
            //} while (
            //!(char.TryParse(Console.ReadLine(), out op)
            //&&
            //(op == '+' || op == '-' || op == '*' || op == '/' || op == '%')));

            //do
            //{
            //    //if(op == '/' || op == '%')
            //    //    Console.WriteLine("enter last number and make sure not be zero");
            //    //else
            //    //    Console.WriteLine("enter last number");

            //    Console.WriteLine($"enter last number{(op == '/' || op == '%' ? " and make sure not be zero" : "")}");

            //} while (
            //!int.TryParse(Console.ReadLine(), out num02)
            //||
            //((op == '/' || op == '%') && num02 == 0) //true
            //);


            ////if (op == '+' || op == '-' || op == '*')
            ////{
            ////    do
            ////    {
            ////        Console.WriteLine("enter last number");
            ////    } while (!int.TryParse(Console.ReadLine(), out num02));
            ////}
            ////else // ( / , % )
            ////{
            ////    do
            ////    {
            ////        Console.WriteLine("enter last number and make sure not be zero");
            ////    } while (!int.TryParse(Console.ReadLine(), out num02) && num02 != 0);
            ////}

            //switch (op)
            //{
            //    case '+': result = num01 + num02; break;
            //    case '-': result = num01 - num02; break;
            //    case '*': result = num01 * num02; break;
            //    case '/': result = (double)num01 / num02; break;
            //    case '%': result = num01 % num02; break;
            //    default: result = 0; break;
            //}

            //Console.WriteLine($"{num01} {op} {num02} = {result}");
            #endregion
            #endregion

            #region Block scope

            //{
            //    int i = 0;
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    i = 1;
            //}

            //Console.WriteLine(i); //invalid [out of scope]

            //bool result = !int.TryParse(Console.ReadLine(), out int x);
            //if (result)
            //{
            //    int y = 0;
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //while(!int.TryParse(Console.ReadLine(), out int x))
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine(x);

            //{
            //    int i = 0;
            //}
            //{
            //    int i = 0;
            //}
            //Console.WriteLine(i);
            #endregion

            #region Arrays

            #region One D Array
            //int[] numbers;
            /////declare for reference from type array of integers
            /////referring to null => default value of reference datatype
            /////4 bytes will be allocated in stack => CLR
            /////zero bytes will be allocated in heap => CLR

            //numbers = new int[5];
            /////clr will allocate 20 bytes [5 * 4 byte] in heap
            /////initizlized with defalt value of int [0]

            //numbers = new int[5] { 1, 2, 3, 4, 5 };
            //numbers = new int[] { 1, 2, 3, 4, 5 };
            ////numbers = new int[]; //invalid

            //int[] numbers2 = { 1, 2, 3, 4, 5 }; // syntax sugar

            //Console.WriteLine(numbers.Length); // size of array

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[5]); //runtime error => index out of range

            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"enter {i + 1} element");
            //    while(!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.WriteLine("invalid input, please enter a valid integer");
            //    }
            //}

            //foreach (int item in numbers)
            //{
            //    //int.TryParse(Console.ReadLine(), out item); // not valid
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Two D array [Rectangler]
            //int[,] Marks;
            //Marks = new int[2, 4]; //{ { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            //Console.WriteLine($"the size of array = {Marks.Length} , the number of dimensions = {Marks.Rank}");
            //Console.WriteLine($"number of rows = {Marks.GetLength(0)} , number of column = {Marks.GetLength(1)}");

            ///read elments of arry from user 
            ///print elemnts of arry to user
            ///write program to do that with protictive code and readable messages

            //for (int i = 0; i < Marks.GetLength(0); i++) //0 , 1 
            //{
            //    for (int j = 0; j < Marks.GetLength(1); j++) //0,1,2,3  0,1,2,3
            //    {
            //        Console.WriteLine($"enter ({i},{j}) element");
            //        while (!int.TryParse(Console.ReadLine(), out Marks[i,j]))
            //        {
            //            Console.WriteLine("invalid input, please enter a valid integer");
            //        }
            //    }
            //}

            //foreach (int item in Marks)
            //{
            //    Console.WriteLine(item);
            //}

            //[quiz] write same program with only one loop
            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    int row = i / Marks.GetLength(1);
            //    int column = i % Marks.GetLength(1);
            //    Console.WriteLine($"insert array element [{row} , {column}]");
            //    while(!int.TryParse(Console.ReadLine(),out Marks[row, column]))
            //    {
            //        Console.WriteLine("invalid input, please insert valid integer");
            //    }
            //}

            #endregion
            #region Two D [Jaged array]
            //int[][,] numbers;
            //numbers = new int[3][,];

            //numbers[0] = new int[3, 5];
            //numbers[1] = new int[1, 3];
            //numbers[2] = new int[2, 1];

            //Console.WriteLine($"the size of array = {numbers.Length} , the number of dimensions = {numbers.Rank}");
            //Console.WriteLine($"the size of array = {numbers[0].Length} , the number of dimensions = {numbers[0].Rank}");
            //Console.WriteLine($"number of rows = {numbers[0].GetLength(0)} , number of column = {numbers[0].GetLength(1)}");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        int r = j / numbers[i].GetLength(1);
            //        int c = j % numbers[i].GetLength(1);
            //        Console.WriteLine($"enter element [{i}][{r},{c}]");
            //        while (!int.TryParse(Console.ReadLine(), out numbers[i][r, c]))
            //        {
            //            Console.WriteLine("invalid input, please enter a valid integer");

            //        }
            //    }
            //}

            //foreach (var item in numbers)
            //{
            //    foreach (var inneritem in item)
            //    {
            //        Console.WriteLine(inneritem);
            //    }
            //}

            #endregion
            #region array methods
            //double[] numbers = { 8, 3, 4, 5, 6, 7, 9, 7, 1, 3, 8 };
            #region 1.calss member method (static)
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Array.Clear(numbers);
            //Console.WriteLine(Array.IndexOf(numbers, 7)); // find first index
            //Console.WriteLine(Array.LastIndexOf(numbers, 7)); // find first index


            //int[] x = new int[5];

            //Array.CreateInstance(typeof(int), 10);
            #endregion
            #region 2.object member method (dynamic)
            //int[] newarr = new int[5];
            //numbers.CopyTo(newarr, 0);
            //numbers.SetValue(18, 5);

            //var dest01 = Array.CreateInstance(numbers.GetType().GetElementType(), numbers.Length);

            //string dest02 = "test";
            //dest02 = 10;
            #endregion
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (int i in newarr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #endregion

            #region Boxing vs Unboxing
            //int x = 10;
            //object obj = x; //parent = child; //boxing => value type to reference type
            //x = 20;
            //Console.WriteLine(obj);

            //object[] data = new object[3];
            //data[0] = 10; // boxing => value type to reference type
            //data[1] = 3200.50m; // boxing => value type to reference type
            //data[2] = "ali"; // not boxing

            //ArrayList list = new ArrayList();
            //list.Add(10); //boxing
            //list.Add("test"); //notboxing
            //list.Add(true); //boxing

            //List<int> ints = new List<int>();
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            ////ints.Add("test"); //invalid

            //int a = ints[0];

            //unboxing
            //int xx =(int)list[0]; //explicit casting => un safe cast

            //object obj01 = 10; // boxing
            //int xx = (int)obj01; //unboxing
            //Console.WriteLine(xx);
            //double y = (double)obj01;//unboxing => invalid
            //Console.WriteLine(y);

            //int a = 10;
            //double b = a;
            //Console.WriteLine(b);

            //animal = dog;
            //animal = cat;
            //dog = animal;
            //child = parent;

            //object O1 = new object();
            //O1 = "string"; //not boxing

            //O1 = 5;    // int[ValueType] to object[ReferenceType] -> Boxing
            //O1 = 'A';  // char[ValueType] to object[ReferenceType] -> Boxing
            //O1 = 3.3;  // double[ValueType] to object[ReferenceType] -> Boxing
            //O1 = true; // bool[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new DateTime();  // DateTime[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new DateOnly(); // DateOnly[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new TimeOnly(); // TimeOnly[ValueType] to object[ReferenceType] -> Boxing
            #endregion

            #region Nullable types
            //int age = null;
            //int age = 0;
            //int? age01 = null; //nullable integer : allow int value + allow null

            //int x = 8;
            //int? y = x;
            //y = null;
            //x = (int)y; //explict casting => un safe cast

            //if (y is not null)
            //    x = (int)y;  //safe cast

            //if (y.HasValue)
            //    x = y.Value;

            //x = y.HasValue ? y.Value : 0;

            /////////null coalescing operator
            //x = y ?? 0;



            //notification
            //string t = null;
            //string? tt = null;

            //Point pt = null!; //null fogiving
            //pt = new Point();
            //pt = null;

            #endregion

            #region null propagation operator
            //int x = default; //0
            //int[] arr = default; //null

            //int length = arr.Length; //runtime error

            //int length;
            //if (arr is not null)
            //    length = arr.Length;

            //if (arr is not null)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {

            //    }
            //}

            //for (int i = 0; arr is not null && i < arr.Length; i++)
            //{

            //}

            //for (int i = 0; arr is not null & i < arr.Length; i++)
            //{

            //}


            //int? length02 = arr?.Length; // int = null


            //int length03 = arr?.Length ?? 0; 

            //employee?.department?.name ?? "N/A"
            #endregion

            #region Functions
            #region Prototype and calling
            //PrintLine();

            //PrintLine(20, "$"); // passing parameters by postion
            //PrintLine(pattern: "$", number: 20);//passing parameters by name
            //PrintLine(20);//not valid

            //printline with default value of parmeters
            //PrintLine();
            //PrintLine(20);
            //PrintLine(pattern: "%");
            //PrintLine(20, "*");
            #endregion

            #region value type
            //class memeber method function take two numbers and swap them
            //int x = 10, y = 20;
            ////Console.WriteLine($"before swap : x = {x} , y = {y}");
            ////Swap(x, y);
            ////Console.WriteLine($"after swap : x = {x} , y = {y}");

            //Console.WriteLine("***********************By ref******************");
            //Console.WriteLine($"before swap : x = {x} , y = {y}");
            //Swap(ref x,ref y);
            //Console.WriteLine($"after swap : x = {x} , y = {y}");

            #endregion

            #region reference type
            //write class memeber method take arr of int one diminssion and return sum of array element
            //int[] numarr = new int[] { 3, 5, 6 };

            //Console.WriteLine("******************passing by value********************");
            ////Console.WriteLine(sumarraybyvalue(numarr));
            ////Console.WriteLine(numarr[0]);
            //sumarraybyvalue(numarr);
            //foreach (int i in numarr)
            //{
            //    Console.WriteLine(i);
            //}

            //numarr[0] = 3;

            //Console.WriteLine("******************passing by ref********************");
            ////Console.WriteLine(sumarraybyref(numarr));
            ////Console.WriteLine(numarr[0]);
            //sumarraybyref(ref numarr);
            //foreach (int i in numarr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Passing by out
            //write class memeber method to take two integer numbers and return sum and mul
            //int.TryParse(Console.ReadLine(), out int x);
            //int x = 10, y = 20, sum, mul;
            ////sumandmul(x, y,ref sum,ref mul);
            //sumandmul(x, y, out sum, out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);

            #endregion

            #region Params
            //int[] numarr = new int[] { 1, 2, 3, 4 };
            //sumarray(numarr);

            //sumarray(1, 2, 3, 4, 5, 6);
            #endregion

            //reference type
            //passing by value vs passing by ref
            //Point p1 = new Point();
            //p1.X = 1;
            //p1.Y = 2;

            //assignpoint(p1); //passing by value
            //Console.WriteLine(p1.X); //1


            //assignpointpassingbyref(ref p1); //passing by ref
            //Console.WriteLine(p1.X); //10

            //Point p2 = default; // null
            ////assignpoint(p2);
            //assignpointpassingbyref(ref p2);
            //Console.WriteLine(p2.X);
            #endregion

            #region Exceptions Handling
            //try
            //{
            //    DoSomeCode();
            //}
            //catch (Exception ex)
            //{
            //    //log
            //    //Console.WriteLine(ex.Message);
            //    throw ex;
            //}
            //finally
            //{
            //    //[release || deallocate || delete || close] unmanaged resources [databaseconnection , files]
            //    Console.WriteLine("finally");
            //}

            //Console.WriteLine("Program is still running");
            #endregion

            #region Enums [labels]
            #region Ex01
            //Days day = Days.mon;
            //Console.WriteLine(day); //day.tostring() => mon
            //Console.WriteLine((int)day); // 2

            //Daysss day01 = Daysss.mon;
            //Console.WriteLine(day01); //day.tostring() => mon
            //Console.WriteLine((int)day01); // 200 
            #endregion
            #region Ex02
            //Console.WriteLine(Gender.Male);
            //Console.WriteLine(Gender.male);
            //Console.WriteLine(Gender.m);
            //Console.WriteLine(Gender.M);
            //Console.WriteLine((int)Gender.Male);
            //Console.WriteLine((int)Gender.male);
            //Console.WriteLine((int)Gender.m);
            //Console.WriteLine((int)Gender.M);
            #endregion
            #endregion
        }

        #region Function
        #region Prototype and calling
        //print line of 10 element of "#"
        //output=> ##########

        // <summary>
        // Function to print line of 10 element of "#"
        // object member method
        // </summary>
        //public void PrintLine()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.Write("#");
        //    }
        //    Console.WriteLine();
        //}

        // <summary>
        // Function to print line of 10 element of "#"
        // class member method
        // </summary>
        //public static void PrintLine()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.Write("#");
        //    }
        //    Console.WriteLine();
        //}

        //print line of number inserted by user and pattern inserted by user



        /// <summary>
        /// Function to print line of number that user defined of element of patter that user defined
        /// </summary>
        /// <param name="number">number of elements</param>
        /// <param name="pattern">pattern to print</param>
        //public static void PrintLine(int number,string pattern)
        //{
        //    for (int i = 1; i <= number; i++)
        //    {
        //        Console.Write(pattern);
        //    }
        //    Console.WriteLine();
        //}

        //public static void PrintLine(int number = 10, string pattern = "#")
        //{
        //    for (int i = 1; i <= number; i++)
        //    {
        //        Console.Write(pattern);
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region value type
        //passing by value
        //static void Swap(int num1 , int num2)
        //{
        //    Console.WriteLine($"inner function before swap : x = {num1} , y = {num2}");
        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    Console.WriteLine($"inner function after swap : x = {num1} , y = {num2}");
        //}

        //passing by ref
        //static void Swap(ref int num1,ref int num2)
        //{
        //    Console.WriteLine($"inner function before swap : x = {num1} , y = {num2}");
        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    Console.WriteLine($"inner function after swap : x = {num1} , y = {num2}");
        //}
        #endregion

        #region reference type
        //static int sumarraybyvalue(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int item in arr)
        //    {
        //        sum += item;
        //    }
        //    //arr[0] = 10;
        //    arr = new int[] { 1, 2, 3 };
        //    return sum;
        //}

        //static int sumarraybyref(ref int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int item in arr)
        //    {
        //        sum += item;
        //    }
        //    //arr[0] = 10;
        //    arr = new int[] { 1, 2, 3 };
        //    return sum;
        //}
        #endregion

        #region Passing by out
        //write class memeber method to take two integer numbers and return sum and mul
        //static result sumandmul(int num1,int num2)
        //{
        //    result re = new result();
        //    re.sum = num1 + num2;
        //    re.mul = num1 * num2;
        //    return re;
        //}


        //static void sumandmul(int num1, int num2,ref int sum ,ref int mul)
        //{
        //    sum = num1 + num2;
        //    mul = num1 * num2;
        //}

        //static void sumandmul(int num1, int num2, out int sum, out int mul)
        //{
        //    //sum = num1 + num2;
        //    //mul = num1 * num2;
        //    Console.WriteLine(num1);
        //}
        #endregion

        #region Params
        //static int sumarray(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int item in arr)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}

        //static int sumarray(int result, params int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int item in arr)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}
        #endregion

        ////passing by value
        //static void assignpoint(Point p)
        //{
        //    p = new Point();
        //    p.X = 10;
        //    p.Y = 20;
        //}

        ////passing by ref
        //static void assignpointpassingbyref(ref Point p)
        //{
        //    p = new Point();
        //    p.X = 10;
        //    p.Y = 20;
        //}
        #endregion

        #region Exceptions Handling
        //static void DoSomeCode()
        //{
        //    int x, y, z;
        //    Console.WriteLine("Please enter first number:");
        //    x = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Please enter last number:");
        //    y = int.Parse(Console.ReadLine());

        //    z = x / y;

        //    Console.WriteLine($"result is : {z}");

        //    int[] arr = { 1, 2, 3 };
        //    Console.WriteLine("please enter index number to change it's value");
        //    int i = int.Parse(Console.ReadLine());

        //    arr[i] = 99;

        //    Console.WriteLine(arr[i]);
        //}

        //static void DoSomeProtictiveCode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        do
        //        {
        //            Console.WriteLine("Please enter first number:");
        //        } while (!int.TryParse(Console.ReadLine(), out x));

        //        do
        //        {
        //            Console.WriteLine("Please enter last number:");
        //        } while (!int.TryParse(Console.ReadLine(), out y) || y == 0);

        //        z = x / y;

        //        Console.WriteLine($"result is : {z}");

        //        int[] arr = { 1, 2, 3 };

        //        int i = 0;

        //        do
        //        {
        //            Console.WriteLine("please enter index number to change it's value");
        //        } while (!int.TryParse(Console.ReadLine(), out i) || i < 0 || i >= arr.Length);

        //        arr[i] = 99;

        //        Console.WriteLine(arr[i]);
        //    } 
        //    catch (Exception ex)
        //    {
        //        //log
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        #endregion
    }

    #region Enums [labels]
    enum Days
    {
        sat,
        sun,
        mon,
        tus,
        wed,
        thr,
        fri
    }

    enum Daysss : int
    {
        sat = 10,
        sun = 100,
        mon = 200,
        tus = 300,
        wed = 400,
        thr = 500,
        fri = 600
    }

    enum Gender : int
    {
        Male = 0,
        male = 0,
        m = 0,
        M = 0,
        Female = 1,
        female = 1,
        f = 1,
        F = 1
    }

    enum Branches : byte // 0 => 255
    {
        samrtvally = 105,
        Madi,
        _6OCT = 252,
        Mansoura, //253
        asyut, //254
        banha, //255
        //suize //256 => not valid [is too large to fit it's datatype]

    }

    #region Ex: Enum + Params 
    ///class member method take tax and service and all ordered items 
    ///print the shape as bellow:
    /// order details :
    /// pizza : 120
    /// juice : 60
    /// ـــــــــــــــــــ
    /// total item : 180
    /// tax : (total item * (tax / 100))
    /// service : (total item * (service  / 100))
    /// ـــــــــــــــــــ
    /// total oreder : total + tax + service
    /// return total + tax + service;
    /// 
    /// Menu items is:
    /// Pizaa = 120,
    /// Burger = 150,
    /// Juice = 40,
    /// Salad = 30,
    /// Dessert = 60

    #endregion
    #endregion




    //class test
    //{
    //    void callingfunction()
    //    {
    //        //Program p1 = new Program();
    //        //p1.PrintLine(); //calling object member method 

    //        Program.PrintLine();
    //    }
    //}

    //class result
    //{
    //    public int sum;
    //    public int mul;
    //}
}
