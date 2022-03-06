using System;

namespace Problems
{
    internal class DeleteAndEarnSolution
    {
        public int DeleteAndEarn(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];


            var count = new int[10002];
            var dp = new int[10002];
            var max = 0;
            foreach (int num in nums)
            {
                count[num]++;
                max = Math.Max(max, num);
            }
            var sum = 0;

            dp[1] = count[1];

            for (var i = 2; i <= max; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + i * count[i], dp[i - 1]);
                sum = Math.Max(sum, dp[i]);
            }
            return sum;
        }
    }
}
