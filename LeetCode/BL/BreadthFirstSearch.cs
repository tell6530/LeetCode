using System.Collections;
using System.Collections.Generic;
using LeetCode.BE;

namespace LeetCode.BL
{
    public class BreadthFirstSearch
    {
        /// <summary>
        /// No.101 Symmetric Tree(Easy)
        /// </summary>
        /// <param name="root">Binary tree node</param>
        /// <returns>
        /// Is Symmetric tree or not
        /// </returns>
        public bool IsSymmetric(TreeNode root)
        {
            var result = true;
            if (root == null) return result;

            var queue = new Queue();
            var tmpList = new List<int?>();
            queue.Enqueue(root);

            while (queue.Count != 0 && result)
            {
                var queueCount = queue.Count;
                for (int i = 0; i < queueCount; i++)
                {
                    var firtNode = (TreeNode)queue.Peek();
                    if (firtNode != null)
                    {
                        var leftTreeNode = firtNode.left;
                        queue.Enqueue(leftTreeNode);
                        if (leftTreeNode == null) tmpList.Add(null);
                        else tmpList.Add(leftTreeNode.val);

                        var rightTreeNode = firtNode.right;
                        queue.Enqueue(rightTreeNode);
                        if (rightTreeNode == null) tmpList.Add(null);
                        else tmpList.Add(rightTreeNode.val);
                    }
                    queue.Dequeue();
                }
                var tmpListCount = tmpList.Count;
                for (int i = 0,j = tmpListCount - 1; i < j; i++, j--)
                {
                    if(tmpList[i] != tmpList[j])
                    {
                        result = false;
                        break;
                    }
                }
                tmpList.Clear();
            }

            return result;
        }
    }
}