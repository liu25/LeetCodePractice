using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem114Test
    {
        [Test]
        public void TestFlatten()
        {
            Problem114 problem114 = new Problem114();

            problem114.Flatten(GetTree());
        }

        private TreeNode GetTree()
        {
            return new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };
        }
    }
}
