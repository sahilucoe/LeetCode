using System;
using System.Linq;
namespace LeetCode
{
    public class TwoSum
    {
        public int[] Solve(int[] nums, int target)
        {
            // 1. Sort the input array
            var input = nums.Select((x, i) => new { x, i }).OrderBy(y=>y.x).ToArray();


            // 2. Iterate over the input array from both the ends
            int start = 0, end = nums.Length - 1;
            while (start < end)
            {
                if (input[start].x + input[end].x == target)
                {
                    break;
                }
                else if (input[start].x + input[end].x < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return new[] { input[start].i, input[end].i };
        }
    }
}
