using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem199Test
    {
        [Test]
        public void TestRightSideView()
        {
            Problem199 problem199 = new Problem199();

            Problem199.TreeNode root = new Problem199.TreeNode(1)
            {
                left = new Problem199.TreeNode(2)
                {
                    right = new Problem199.TreeNode(5)
                },
                right = new Problem199.TreeNode(3)
                {
                    right = new Problem199.TreeNode(4)
                }
            };

            var result = problem199.RightSideView(root);

            Assert.AreEqual(result[0], 1);

            Assert.AreEqual(result[1], 3);

            Assert.AreEqual(result[2], 4);

            root = new Problem199.TreeNode(1)
            {
                left = new Problem199.TreeNode(2)
            };

            result = problem199.RightSideView(root);

            Assert.AreEqual(result[0], 1);

            Assert.AreEqual(result[1], 2);

            root = new Problem199.TreeNode(1)
            {
                left = new Problem199.TreeNode(2),
                right = new Problem199.TreeNode(3)
                {
                    right = new Problem199.TreeNode(4)
                }
            };

            result = problem199.RightSideView(root);

            Assert.AreEqual(result[0], 1);

            Assert.AreEqual(result[1], 3);

            Assert.AreEqual(result[2], 4);
        }
    }
}
