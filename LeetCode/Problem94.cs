using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem94
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

        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Helper(root, res);
            return res;
        }

        private void Helper(TreeNode root, List<int> res)
        {
            if (root == null)
                return;
            Helper(root.left, res);
            res.Add(root.val);
            Helper(root.right, res);
        }
    }
}
