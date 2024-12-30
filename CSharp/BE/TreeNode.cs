using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.CSharp.BE
{
    public class TreeNode
    {
        public int val;
        
        public TreeNode left;
        
        public TreeNode right;
        
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public TreeNode Create(IEnumerable<int?> ints)
        {
            if (ints is null || ints.Any() == false)
                return null;
            
            return Create(ints, 0, 0);
        }

        public IEnumerable<int> LevelOrderTraversal()
        {
            var result = new List<int>();
            if (this is null)
                return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                var levelLen = queue.Count;
                for (int i = 0; i < levelLen; i++)
                {
                    var node = queue.Dequeue();
                    result.Add(node.val);

                    if (node.left is not null)
                        queue.Enqueue(node.left);

                    if (node.right is not null)
                        queue.Enqueue(node.right);
                }
            }

            return result;
        }

        private TreeNode Create(IEnumerable<int?> ints, int level, int index)
        {
            if (ints is null || ints.Any() == false)
                return null;
            
            if ((int)Math.Pow(2, level) > ints.Count())
                return null;

            if (ints.ElementAt((int)Math.Pow(2, level) + index - 1).HasValue == false)
                return null;

            var result = new TreeNode
            {
                val = ints.ElementAt((int)Math.Pow(2, level) + index - 1).Value,
                left = Create(ints, level + 1, 2 * index),
                right = Create(ints, level + 1, (2 * index) + 1),
            };

            return result;
        }
    }
}