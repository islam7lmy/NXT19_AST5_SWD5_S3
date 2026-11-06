using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Delegates
{
    public delegate bool SortingTypesFuncDelegate(int x, int y);
    public delegate bool GenericsSortingTypesFuncDelegate<T>(T x, T y);
    internal class SortingAlgorithm
    {
        #region Without Delegates
        public static void BubbleSorting(int[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {

                        if (arr[j] > arr[j + 1])
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        public static void BubbleDescSorting(int[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {

                        if (arr[j] < arr[j + 1])
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region WithDelegates
        #region NonGenerics
        public static void BubbleSortingWithType(int[] arr, SortingTypesFuncDelegate reference)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {

                        if (reference.Invoke(arr[j], arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        #endregion

        #region Generics
        public static void BubbleSortingWithType<T>(T[] arr, GenericsSortingTypesFuncDelegate<T> reference)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {

                        if (reference.Invoke(arr[j], arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion
        #endregion
    }

    class SortingTypes
    {
        public static bool SortAsc(int a, int b)
        {
            return a > b;
        }

        public static bool SortDesc(int a, int b)
        {
            return a < b;
        }

        public static bool SortAsc<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0;
        }

        public static bool SortDesc<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) < 0;
        }
    }
}
