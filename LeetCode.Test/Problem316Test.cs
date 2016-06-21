using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem316Test
    {
        [Test]
        public void TestRemoveDuplicateLetters()
        {
            Problem316 problem316 = new Problem316();

            var result = problem316.RemoveDuplicateLetters("bcabc");

            Assert.AreEqual(result, "abc");

            result = problem316.RemoveDuplicateLetters("cbacdcbc");

            Assert.AreEqual(result, "acdb");

            result = problem316.RemoveDuplicateLetters("bca");

            Assert.AreEqual(result, "bca");
        }
    }
}
