using Problems;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new TwoSum_SortedArray();
            t.TwoSum(new[] { 2, 3, 4 },6);
            t.TwoSum(new[] { -1, 0 },-1);
        }
    }
}
