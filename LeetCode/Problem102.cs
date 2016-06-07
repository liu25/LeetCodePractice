using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem102
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int x)
            {
                val = x;
            }
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var tree = new List<IList<int>>();

            Traverse(root, tree, 0);

            return tree;
        }

        private void Traverse(TreeNode node, List<IList<int>> tree, int level)
        {
            if (node == null)
                return;

            if(tree.Count < level + 1)
                tree.Add(new List<int>());

            tree[level].Add(node.val);

            Traverse(node.left, tree, level + 1);

            Traverse(node.right, tree, level + 1);
        }
    }
}
