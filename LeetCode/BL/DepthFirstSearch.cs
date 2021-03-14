using System.Collections.Generic;
using LeetCode.BE;

namespace LeetCode.BL
{
    public class DepthFirstSearch
    {
        /// <summary>
        /// No.100 Same Tree(Easy)
        /// </summary>
        /// <param name="p">Binary tree node</param>
        /// <param name="q">Binary tree node</param>
        /// <returns>
        /// Is same tree or not
        /// </returns>
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q != null) return false;
            if (p != null && q == null) return false;
            if (p == null && q == null) return true;

            var rightResult = this.IsSameTree(p.right, q.right);
            var currentResult = (p.val == q.val) ? true : false;
            var leftResult = this.IsSameTree(p.left, q.left);
            
            return rightResult && currentResult && leftResult;
        }
    }
}