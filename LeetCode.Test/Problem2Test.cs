using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem2Test
    {
        [Test]
        public void TestTwoSum()
        {
            Problem2 problem2 = new Problem2();

            var res = problem2.TwoSum(new[] {2, 7, 11, 15}, 9);

            Assert.AreEqual(res[0], 0);

            Assert.AreEqual(res[1], 1);

            res = problem2.TwoSum(new[] { 3, 2, 4 }, 6);

            Assert.AreEqual(res[0], 1);

            Assert.AreEqual(res[1], 2);

            res = problem2.TwoSum(new[] { 3, 3, 4 }, 6);

            Assert.AreEqual(res[0], 0);

            Assert.AreEqual(res[1], 1);

            res = problem2.TwoSum(new[] { 0, 4, 3, 0 }, 0);

            Assert.AreEqual(res[0], 0);

            Assert.AreEqual(res[1], 3);
        }
    }
}
