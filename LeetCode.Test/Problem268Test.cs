using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem268Test
    {
        [Test]
        public void TestMissingNumber()
        {
            Problem268 problem268 = new Problem268();

            Assert.AreEqual(problem268.MissingNumber(new int[] { 0, 1, 3}), 2);

            Assert.AreEqual(problem268.MissingNumber(new int[] { 0}), 1);

            Assert.AreEqual(problem268.MissingNumber(new int[] { 1 }), 0);

            Assert.AreEqual(problem268.MissingNumber(new int[] { 1, 0 }), 2);

            Assert.AreEqual(problem268.MissingNumber(new int[] { 1, 2 }), 0);
        }
    }
}
