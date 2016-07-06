using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem162Test
    {
        [Test]
        public void TestFindPeakElement()
        {
            Problem162 problem162 = new Problem162();

            Assert.AreEqual(problem162.FindPeakElement(new int[] { 1, 2, 3, 1 }), 2);

            Assert.AreEqual(problem162.FindPeakElement(new int[] { 1 }), 0);

            Assert.AreEqual(problem162.FindPeakElement(new int[] { 1, 2 }), 1);
        }
    }
}
