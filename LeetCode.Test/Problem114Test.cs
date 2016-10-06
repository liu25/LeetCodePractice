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

        private Problem114.TreeNode GetTree()
        {
            return new Problem114.TreeNode(1)
            {
                left = new Problem114.TreeNode(2),
                right = new Problem114.TreeNode(3)
            };
        }
    }
}
