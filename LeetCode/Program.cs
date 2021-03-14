using System;
using LeetCode.BL;
namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new int[7] {2,1,2,1,0,1,2};

            var dp = new DynamicProgramming();

            var max = dp.MaxProfit(test);
        }
    }
}
