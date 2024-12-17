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
    }
}