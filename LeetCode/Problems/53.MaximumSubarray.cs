using System;
using System.Linq;

namespace Problems
{
    internal class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            if(nums.Length == 1)
            {
                return nums[0];
            }
            var dp = new int[nums.Length];
            dp[0] = Math.Max(0, nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = Math.Max(nums[i], nums[i]+dp[i-1]);
            }
            return dp.Max();
        }
    }
}
