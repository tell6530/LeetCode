using System.Collections.Generic;

namespace LeetCode.CSharp.BL
{
    public class Graph
    {
        /// <summary>
        /// No.997 Find the Town Judge(Easy)
        /// </summary>
        /// <param name="N">Number of people</param>
        /// <param name="trust">Graph of trust</param>
        /// <returns>
        /// The town judge
        /// </returns>
        public int FindJudge(int N, int[][] trust)
        {
            if (trust.Length == 0 && N == 1) return 1;

            var result = -1;
            var personTrustDic = new Dictionary<int, int>();

            for (int i = 0; i < trust.Length; i++)
            {
                if (personTrustDic.ContainsKey(trust[i][0]) == false)
                {
                    personTrustDic.Add(trust[i][0], -1);
                }
                else
                {
                    personTrustDic[trust[i][0]] += -1;
                }

                if (personTrustDic.ContainsKey(trust[i][1]) == false)
                {
                    personTrustDic.Add(trust[i][1], 1);
                }
                else
                {
                    personTrustDic[trust[i][1]] += 1;
                }
            }

            foreach (var item in personTrustDic)
            {
                if (item.Value == N - 1) result = item.Key;
            }

            return result;
        }
    }
}