using System;

namespace LeetCode.CSharp.BL
{
    public class Greedy
    {
        /// <summary>
        /// No.122 Best Time to Buy and Sell Stock II(Easy)
        /// </summary>
        /// <param name="prices">List of prices</param>
        /// <returns>
        /// Maxinum profit
        /// </returns>
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1) return 0;

            var maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                var profit = prices[i] - prices[i - 1];
                maxProfit += profit > 0 ? profit : 0;
            }

            return maxProfit;
        }
    }
}