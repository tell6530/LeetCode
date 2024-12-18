using System;
using System.Linq;

namespace LeetCode.CSharp.BL
{
    public class DynamicProgramming
    {
        /// <summary>
        /// No.121 Best Time to Buy and Sell Stock(Easy)
        /// </summary>
        public int MaxProfit(int[] prices)
        {
            var minPrice = 0;
            var maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                minPrice = (minPrice == 0 && i == 0) ? prices[i] : Math.Min(prices[i], minPrice);
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }

            return maxProfit;
        }

        /// <summary>
        /// No.746 Min Cost Climbing Stairs(Easy)
        /// </summary>
        public int MinCostClimbingStairs(int[] cost)
        {
            var arrayLength = cost.Length;
            var resultArray = new int[arrayLength + 1];

            resultArray[0] = 0;
            resultArray[1] = 0;

            for (int i = 2; i <= arrayLength; i++)
            {
                resultArray[i] = Math.Min(cost[i - 1] + resultArray[i - 1], cost[i - 2] + resultArray[i -2]);
            }

            return resultArray[arrayLength];
        }
    }
}