using System.Collections.Generic;
using LeetCode.CSharp.BE;

namespace LeetCode.CSharp.BL
{
    public class DepthFirstSearch
    {
        /// <summary>
        /// No.100 Same Tree(Easy)
        /// </summary>
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