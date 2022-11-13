using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            List<int> sumOfFive = new List<int>();
            
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) even.Add(nums[i]);
                else odd.Add(nums[i]);
                int sumOfDigits = 0;
                int number = nums[i];
                while (number != 0)
                {
                    sumOfDigits += number % 10;
                    number /= 10;
                }
                if (sumOfDigits % 5 == 0) sumOfFive.Add(nums[i]);
            }
            
            Console.WriteLine(string.Join(".",even));
            Console.WriteLine(string.Join(".", odd));
            Console.WriteLine(string.Join(".", sumOfFive));
        }
    }
}
