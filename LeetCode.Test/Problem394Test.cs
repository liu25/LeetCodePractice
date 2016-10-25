using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem394Test
    {
        [Test]
        public void TestDecode()
        {
            Problem394 problem394 = new Problem394();

            Assert.AreEqual(problem394.DecodeString("3[a]2[bc]"), "aaabcbc");

            Assert.AreEqual(problem394.DecodeString("3[a2[c]]"), "accaccacc");

            Assert.AreEqual(problem394.DecodeString("2[abc]3[cd]ef"), "abcabccdcdcdef");
        }
    }
}
