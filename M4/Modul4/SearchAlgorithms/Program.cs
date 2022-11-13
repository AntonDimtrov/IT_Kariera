using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i = BinarySearch.Search(nums, 4);
            Console.WriteLine(i);
        }
    }
    public static class LinearSearch
    {
        public static int Search<T>(T[] elements, T element) where T : IComparable<T>
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].CompareTo(element) == 0)
                {
                    Console.WriteLine($"index -> {i}");
                    return i;
                }
            }
            return -1;
        }
    }
    public static class BinarySearch
    {
        public static int Search<T>(T[] elements, T e) where T : IComparable
        {
            int min = 0;
            int max = elements.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (e.CompareTo(elements[mid]) == 0)
                {
                    return mid;
                }
                else if (e.CompareTo(elements[mid]) > 0)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }
    }
}
