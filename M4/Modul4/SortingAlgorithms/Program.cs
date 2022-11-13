using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 3, 6, 1, 7, 8 };
            /*List<int> list2*/CountingSort.Sort(list1.ToArray());
            //Console.WriteLine(string.Join(" ", list2));
            BubbleSort.Sort(list1.ToArray());
        }
        public static (int element, int index) GetMinElementIndex(List<int> list)
        {
            int index = 0;
            int element = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < element)
                {
                    element = list[i];
                    index = i;
                }
            }
            return (element, index);
        }
        public static List<int> SelectionSort(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int element = list[i];
                int minValue = list[i];
                int index = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < minValue)
                    {
                        minValue = list[j];
                        index = j;
                    }
                }
                list[i] = minValue;
                list[index] = element;

            }
            return list;
        }
        public static List<int> BubbleSort1(List<int> list)
        {
            //Double for cycle
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count - 1; j++)
                {
                    if (list[i] > list[j])
                    {
                        (list[i], list[j]) = Swap(list[i], list[j]);
                    }
                }
            }
            return list;
        }
        public static List<int> BubbleSortAdvanced(List<int> list)
        {
            //While cycle
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        (list[i], list[i + 1]) = Swap(list[i], list[i + 1]);
                        swap = true;
                    }
                }
            }
            return list;

        }
        public static List<int> InsertionSort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                while (i > 0 && list[i - 1] > list[i])
                {
                    (list[i], list[i - 1]) = Swap(list[i], list[i - 1]);
                    i--;
                }
            }
            return list;
        }
        public static (int x, int y) Swap(int x, int y)
        {
            return (y, x);
        }
       

        
    }
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (isBigger(array[i], array[i + 1]))
                    {
                        Swap(array, i, i + 1);
                        swap = true;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", array));

        }
        private static bool isBigger(IComparable first, IComparable second)
        {
            return first.CompareTo(second) > 0;
        }
        private static void Swap<T>(T[] array, int from, int to)
        {
            var temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }
    }
    public static class InsertedSort { }
    public static class SelectionSort { }
    public static class MergeSort
    {
        public static List<int> Sort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }
        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
    public static class CountingSort
    {
        public static void Sort(int[] unsorted)
        {
            int[] result = new int[unsorted.Max()+1];
            for(int i = 0; i < unsorted.Length; i++)
            {
                result[unsorted[i]]++;
            }
            for(int i = 0; i < result.Length; i++)
            {
                if (result[i] > 0) Console.Write(new string(i.ToString().ToCharArray()[0], result[i]));
            }
            
            Console.WriteLine();

        }
    }



}
