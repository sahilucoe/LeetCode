using System;

namespace Problems
{
    internal class MinCostClimbingStairsSolution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length == 0)
            {
                return 0;
            }
            if(cost.Length == 1)
            {
                return cost[0];
            }
            if(cost.Length ==2)
            {
                return Math.Min(cost[0], cost[1]);
            }

            var dp = new int[cost.Length];
            dp[0] = cost[0];
            dp[1] = cost[1];

            for(int i = 2; i < cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i-1] + cost[i], dp[i-2]+cost[i]);
            }
            return Math.Min(dp[cost.Length-1],dp[cost.Length-2]);
        }
    }
}
