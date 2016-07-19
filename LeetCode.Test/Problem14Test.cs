using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem14Test
    {
        [Test]
        public void TestLongestCommonPrefix()
        {
            Problem14 problem14 = new Problem14();

            Assert.AreEqual(problem14.LongestCommonPrefix(null), "");

            Assert.AreEqual(problem14.LongestCommonPrefix(new string[0]), "");

            Assert.AreEqual(problem14.LongestCommonPrefix(new[] {"", ""}), "");

            Assert.AreEqual(problem14.LongestCommonPrefix(new[] { "c", "c" }), "c");

            Assert.AreEqual(problem14.LongestCommonPrefix(new[] { "b", "cb", "cab" }), "");

            Assert.AreEqual(problem14.LongestCommonPrefix(new[] {"abc" }), "abc");

            Assert.AreEqual(problem14.LongestCommonPrefix(new[] {"abbbc", "abbcc", "abccc"}), "ab");
        }
    }
}
