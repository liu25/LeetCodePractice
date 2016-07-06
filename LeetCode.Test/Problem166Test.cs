using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem166Test
    {
        [Test]
        public void TestFractionToDecimal()
        {
            Problem166 problem166 = new Problem166();

            Assert.AreEqual(problem166.FractionToDecimal(1, 2), "0.5");

            Assert.AreEqual(problem166.FractionToDecimal(2, 1), "2");

            Assert.AreEqual(problem166.FractionToDecimal(2, 3), "0.(6)");

            Assert.AreEqual(problem166.FractionToDecimal(-50, 8), "-6.25");
        }
    }
}
