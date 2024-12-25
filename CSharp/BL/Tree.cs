
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LeetCode.CSharp.BE;

namespace LeetCode.CSharp.BL
{
    public class Tree
    {
        /// <summary>
        /// No.515 Find Largest Value in Each Tree Row(Medium)
        /// </summary>
        public IList<int> LargestValues(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
                return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var maxVal = int.MinValue;
                var levelLen = queue.Count;

                for (var i = 0; i < levelLen; i++)
                {
                    var node = queue.Dequeue();
                    if (node.val > maxVal)
                        maxVal = node.val;

                    if (node.left is not null)
                        queue.Enqueue(node.left);

                    if (node.right is not null)
                        queue.Enqueue(node.right);
                }

                result.Add(maxVal);
            }

            return result;
        }
    }
}