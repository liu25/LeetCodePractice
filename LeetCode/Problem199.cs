using System.Collections.Generic;

namespace LeetCode
{
    public class Problem199
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

        public IList<int> RightSideView(TreeNode root)
        {
            List<int> values = new List<int>();

            if (root == null)
                return values;

            FillRightSideView(values, root);

            return values;
        }

        private void FillRightSideView(List<int> values, TreeNode node)
        {
            values.Add(node.val);

            if (node.right != null)
            {
     
            }
        }
    }
}
