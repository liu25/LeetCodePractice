using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem228Test
    {
        [Test]
        public void TestSummaryRanges()
        {
            Problem228 problem228 = new Problem228();

            Assert.AreEqual(problem228.SummaryRanges(null).Count, 0);

            Assert.AreEqual(problem228.SummaryRanges(new int[0]).Count, 0);

            Assert.AreEqual(problem228.SummaryRanges(new[] {0, 1})[0], "0->1");

            Assert.AreEqual(problem228.SummaryRanges(new[] { 0, 1, 2, 4, 5, 7 })[0], "0->2");

            Assert.AreEqual(problem228.SummaryRanges(new[] { 0, 1, 2, 4, 5, 7 })[1], "4->5");

            Assert.AreEqual(problem228.SummaryRanges(new[] { 0, 1, 2, 4, 5, 7 })[2], "7");

            Assert.AreEqual(problem228.SummaryRanges(new[] { -2147483648, -2147483647, 2147483647 })[0], "-2147483648->-2147483647");

            Assert.AreEqual(problem228.SummaryRanges(new[] { -2147483648, -2147483647, 2147483647 })[1], "2147483647");
        }
    }
}
