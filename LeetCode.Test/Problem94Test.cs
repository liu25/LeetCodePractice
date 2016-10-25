using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem94Test
    {
        [Test]
        public void TestInorderTraversal()
        {
            Problem94 problem94 = new Problem94();

            var res = problem94.InorderTraversal(new Problem94.TreeNode(1)
            {
                right = new Problem94.TreeNode(2)
                {
                    left = new Problem94.TreeNode(3)
                }
            });

            Assert.AreEqual(res.Count, 3);

            Assert.AreEqual(res[0], 1);

            Assert.AreEqual(res[1], 3);

            Assert.AreEqual(res[2], 2);
        }
    }
}
