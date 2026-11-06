using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Delegates
{
    public delegate bool NumberFindingFuncDelegate(int number);
    public delegate bool GenericsNumberFindingFuncDelegate<T>(T number);
    public delegate TResult EnhanceGenericsNumberFindingFuncDelegate<in T, out TResult>(T number);
    internal class NumberFinding
    {
        #region Without Delegate
        public static List<int> FindOddNumbers(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    oddNumbers.Add(number);
                }
            }
            return oddNumbers;
        }
        public static List<int> FindEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            return evenNumbers;
        }

        public static List<int> FindNumbersDivisibleBySeven(List<int> numbers)
        {
            List<int> divisibleBySevenNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 7 == 0)
                {
                    divisibleBySevenNumbers.Add(number);
                }
            }
            return divisibleBySevenNumbers;
        }
        #endregion

        #region withDelegates
        public static List<int> FindNumbers(List<int> numbers, NumberFindingFuncDelegate reference)
        {
            List<int> filteredNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (reference(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers;
        }


        public static List<T> FindNumbers<T>(List<T> numbers, GenericsNumberFindingFuncDelegate<T> reference)
        {
            List<T> filteredNumbers = new List<T>();
            foreach (T number in numbers)
            {
                if (reference(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers;
        }

        public static List<T> FindNumbers<T>(List<T> numbers, EnhanceGenericsNumberFindingFuncDelegate<T, bool> reference)
        {
            List<T> filteredNumbers = new List<T>();
            foreach (T number in numbers)
            {
                if (reference(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers;
        }


        public static List<T> FindNumbers<T>(List<T> numbers, Predicate<T> reference)
        {
            List<T> filteredNumbers = new List<T>();
            foreach (T number in numbers)
            {
                if (reference(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers;
        }

        public static List<T> FindNumbers<T>(List<T> numbers, Func<T, bool> reference)
        {
            List<T> filteredNumbers = new List<T>();
            foreach (T number in numbers)
            {
                if (reference(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers;
        }
        #endregion
    }

    #region NumberConditions
    class NumberConditions
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool IsDivisibleBySeven(int number)
        {
            return number % 7 == 0;
        }
        public static bool CheckLength(string str)
        {
            return str.Length > 4;
        }
    }
    #endregion
}
