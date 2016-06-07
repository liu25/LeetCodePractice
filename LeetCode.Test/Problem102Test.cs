using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem102Test
    {
        [Test]
        public void TestLevelOrder()
        {
            Problem102 problem102 = new Problem102();

            var result = problem102.LevelOrder(GetTreeNode());

            Assert.AreEqual(result.Count, 3);

            Assert.AreEqual(result[0].Count, 1);

            Assert.AreEqual(result[0][0], 3);

            Assert.AreEqual(result[1].Count, 2);

            Assert.AreEqual(result[1][0], 9);

            Assert.AreEqual(result[1][1], 20);

            Assert.AreEqual(result[2].Count, 2);

            Assert.AreEqual(result[2][0], 15);

            Assert.AreEqual(result[2][1], 7);
        }

        private Problem102.TreeNode GetTreeNode()
        {
            return new Problem102.TreeNode(3)
            {
                left = new Problem102.TreeNode(9),
                right = new Problem102.TreeNode(20)
                {
                    left = new Problem102.TreeNode(15),
                    right = new Problem102.TreeNode(7)
                }
            };
        }
    }
}
