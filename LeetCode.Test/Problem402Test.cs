using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem402Test
    {
        [Test]
        public void TestRemoveKdigits()
        {
            Problem402 problem402 = new Problem402();

            Assert.AreEqual(problem402.RemoveKdigits("1432219", 3), "1219");

            Assert.AreEqual(problem402.RemoveKdigits("10200", 1), "200");

            Assert.AreEqual(problem402.RemoveKdigits("10", 2), "0");

            Assert.AreEqual(problem402.RemoveKdigits("10", 1), "0");
        }
    }
}
