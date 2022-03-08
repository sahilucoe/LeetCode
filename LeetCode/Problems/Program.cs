using Problems;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] dp = new int[3][];
            dp[0] = new int[3] {1,1,1};
            dp[1] = new int[3] {1,1,0};
            dp[2] = new int[3] {1,0,1};

            var f = new FloodFillSolution();
            f.FloodFill(dp,1,1,2);

        }
    }
}
