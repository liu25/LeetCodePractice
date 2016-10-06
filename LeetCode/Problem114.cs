using System.Collections.Generic;

namespace LeetCode
{
    public class Problem114
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

        public void Flatten(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            TreeNode node = root;

            while (node != null || stack.Count != 0)
            {
                if (node != null && node.right != null)
                {
                    stack.Push(node.right);
                }

                if (node != null && node.left != null)
                {
                    node.right = node.left;
                    node.left = null;
                }
                else if (node != null && stack.Count != 0)
                {
                    node.right = stack.Pop();
                }
                else if (node == null && stack.Count != 0)
                {
                    node = stack.Pop();
                }

                if (node != null)
                    node = node.right;
            }
        }
    }
}
