using System;

namespace Problems
{
    internal class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            var greaterOnRight = new int[prices.Length];
            greaterOnRight[prices.Length - 1] = prices[prices.Length - 1];

            for(int i = prices.Length - 2; i >= 0; i--)
            {
                greaterOnRight[i] = Math.Max(prices[i], greaterOnRight[i + 1]);
            }
            var result = 0;
            for(int i = 0; i < greaterOnRight.Length; i++)
            {
                result = Math.Max(result, greaterOnRight[i] - prices[i]);
            }
            return result;
        }
    }
}
