using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal static class Helper
    {
        #region Ex01: Swap
        #region NonGenerics
        public static void Swap(ref object x, ref object y)
        {
            object temp = x;
            x = y;
            y = temp;
        }

        //public static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void Swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void Swap(ref string x, ref string y)
        //{
        //    string temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion
        #region Generics
        // T 
        public static void Swap<hamada>(ref hamada x, ref hamada y)
        {
            hamada temp = x;
            x = y;
            y = temp;
        }

        //public static void Swap<T1, T2>(ref T1 x, ref T2 y)
        //{
        //    T1 temp = x;
        //    x = (T1)y;
        //    y = (T2)temp;
        //}
        #endregion
        #endregion

        #region Ex02: SearchArray
        #region NonGenerics
        //public static int SearchArray(int[] arr, int value)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == value)
        //                return i;
        //        }
        //    }
        //    return -1;
        //}

        //public static int SearchArray(Point[] arr, Point value)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == value)
        //                return i;
        //        }
        //    }
        //    return -1;
        //}

        //public static int SearchArray(Point[] arr, Point value)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {

        //            if (arr[i].Equals(value))
        //                return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        #region Generics
        public static int SearchArray<T>(T[] arr, T value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(value))
                        return i;
                }
            }
            return -1;
        }
        #endregion
        #endregion

        #region Ex03: GetMax
        public static T GetMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (T item in arr)
            {
                if(item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }
        #endregion

    }

    #region Constraints
    public class Repository<T> where T : class,IComparable<T>
    {

    }
    public class Repository02<T> where T : notnull
    {

    }
    public class Calculater<T> where T : struct
    {

    }

    public class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }
    #endregion

    #region BaseClass
    class Employee
    {
        public string Name { get; set; }
    }

    class Manager : Employee
    {

    }

    class Developer : Employee
    {

    }
    class EmployeeService<T> where T : Employee
    {
        public void PrintEmployeeName(T employee)
        {
            Console.WriteLine($"Employee Name: {employee.Name}");
        }
    }

    class Animal
    {

    }
    class Dog : Animal { }

    class AnimalContaner<T,U> where T : U
    {
        public AnimalContaner(T dog)
        {
            U animal = dog;
        }
    }
    #endregion
}
