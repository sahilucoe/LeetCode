namespace Problems
{
    internal class CountingBits
    {
        public int[] CountBits(int n)
        {
            var dp = new int[n + 1];
            dp[0] = 0;

            var temp = 1;
            while (temp <= n)
            {
                dp[temp] = 1;
                temp = temp * 2;
            }

            var nearest = 2;
            for (int i = 3; i <= n; i++)
            {
                if (dp[i] == 1)
                {
                    nearest = i;
                }
                else
                {
                    dp[i] = 1 + dp[i - nearest];
                }
            }
            return dp;
        }
    }
}
