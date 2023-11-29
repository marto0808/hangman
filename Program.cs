using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums1Count = int.Parse(Console.ReadLine());
            List<int> nums1 = new List<int>();
            for (int i = 0; i < nums1Count; i++)
            {
                nums1.Add(int.Parse(Console.ReadLine()));
            }

            int nums2Count = int.Parse(Console.ReadLine());
            List<int> nums2 = new List<int>();
            for (int i = 0; i < nums2Count; i++)
            {
                nums2.Add(int.Parse(Console.ReadLine()));
            }

            List<int> result = GetRemainingElements(nums1, nums2);
            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> GetRemainingElements(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            int minCount = Math.Min(list1.Count, list2.Count);

            for (int i = minCount; i < list1.Count; i++)
            {
                result.Add(list1[i]);
            }

            for (int i = minCount; i < list2.Count; i++)
            {
                result.Add(list2[i]);
            }

            return result;
        }
    }
}
