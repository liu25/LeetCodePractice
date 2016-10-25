using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem91Test
    {
        [Test]
        public void TestNumDecoding()
        {
            Problem91 problem91 = new Problem91();

            Assert.AreEqual(problem91.NumDecodings("12352468"), 6);
        }
    }
}
