using System;
using System.Globalization;

namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split('|').ToList();
            nums.Reverse();
            List<string> result = new List<string>();

            for (int i = 0; i < nums.Count; i++)
            {
                string str = nums[i].Replace(" ", String.Empty);
                foreach (char ch in str)
                {
                    result.Add(ch.ToString());
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
