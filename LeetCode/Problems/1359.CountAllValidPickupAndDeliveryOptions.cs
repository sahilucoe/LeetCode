namespace Problems
{
    internal class CountAllValidPickupAndDeliveryOptions
    {
        public int CountOrders(int n)
        {
            var dp = new long[n + 1];
            dp[1] = 1;
            for (var i = 2; i <= n; i++)
            {
                dp[i] = (dp[i - 1] * 2 * i * (2 * i - 1) / 2) % 1000000007;
            }
            return (int)dp[n];
        }
    }
}
