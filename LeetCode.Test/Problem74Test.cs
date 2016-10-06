using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem74Test
    {
        [Test]
        public void TestMatrixMatch()
        {
            Problem74 problem74 = new Problem74();

            Assert.IsTrue(problem74.SearchMatrix(GetMatrix(), 3));

            Assert.IsFalse(problem74.SearchMatrix(
                new[,]
                {
                    {1},
                    {3}
                }, 4));

            Assert.IsTrue(problem74.SearchMatrix(
                new[,]
                {
                    {1},
                    {4}
                }, 4));

            Assert.IsFalse(problem74.SearchMatrix(
                new[,]
                {
                    {1, 3, 5},
                }, 2));

            Assert.IsFalse(problem74.SearchMatrix(
                new[,]
                {
                    {1, 3, 5},
                }, 4));

            Assert.IsTrue(problem74.SearchMatrix(
                new[,]
                {
                    {1, 3, 5},
                }, 5));

            Assert.IsTrue(problem74.SearchMatrix(
                new[,]
                {
                    {1, 1},
                    {2, 2}
                }, 2));

            Assert.IsTrue(problem74.SearchMatrix(
                new[,]
                {
                    {-10, -10}, {-9, -9}, {-8, -6}, {-4, -2}, {0, 1}, {3, 3}, {5, 5}, {6, 8}
                }, 0));
        }

        private int[,] GetMatrix()
        {
            return new int[3, 4]
            {
                {1, 3, 5, 7},
                {10, 11, 16, 20},
                {23, 30, 34, 50}
            };
        }
    }
}
