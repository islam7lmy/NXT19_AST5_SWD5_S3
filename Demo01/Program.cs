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
            int X = 1_000_000_000; //_ discard to improve readabilty

            double d1 = 15.3;
            float f1 = 15.3f;
            decimal m1 = 15.3m;
            #endregion
        }
    }
}
