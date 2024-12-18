using System.Collections.Generic;

namespace LeetCode.CSharp.BL
{
    public class Array
    {
        /// <summary>
        /// No.1 Two Sum(Easy)
        /// </summary>
        /// <param name="nums">List of numbers</param>
        /// <param name="target">Target number</param>
        /// <returns>
        /// Array of index
        /// </returns>
        public int[] TwoSum(int[] nums, int target)
        {
            var remainValueAndIndexDic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var remainValue = target - nums[i];

                if (remainValueAndIndexDic.ContainsKey(nums[i]))
                {
                    return new int[] {remainValueAndIndexDic[nums[i]], i};
                }
                
                remainValueAndIndexDic.Add(remainValue, i);
            }

            return null;
        }

        /// <summary>
        /// No.1475 Final Prices With a Special Discount in a Shop(Easy)
        /// </summary>
        public int[] FinalPrices(int[] prices)
        {
            var length = prices.Length;
            var result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = prices[i];

                for (int j = i + 1; j < length; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        result[i] = prices[i] - prices[j];
                        break;
                    }
                }
            }

            return result;
        }
    }
}