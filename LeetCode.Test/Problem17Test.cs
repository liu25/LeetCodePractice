using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem17Test
    {
        [Test]
        public void TestLetterCombinations()
        {
            Problem17 problem17 = new Problem17();

            var results = problem17.LetterCombinations("23");

            Assert.AreEqual(results.Count, 9);

            Assert.AreEqual(results[0], "ad");
            Assert.AreEqual(results[1], "ae");
            Assert.AreEqual(results[2], "af");
            Assert.AreEqual(results[3], "bd");
            Assert.AreEqual(results[4], "be");
            Assert.AreEqual(results[5], "bf");
            Assert.AreEqual(results[6], "cd");
            Assert.AreEqual(results[7], "ce");
            Assert.AreEqual(results[8], "cf");
        }
    }
}
