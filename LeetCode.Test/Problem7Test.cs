using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem7Test
    {
        [Test]
        public void TestReverse()
        {
            Problem7 problem7 = new Problem7();

            Assert.AreEqual(problem7.Reverse(123), 321);

            Assert.AreEqual(problem7.Reverse(1534236469), 0);

            Assert.AreEqual(problem7.Reverse(-2147483648), 0);

            Assert.AreEqual(problem7.Reverse1(123), 321);

            Assert.AreEqual(problem7.Reverse1(1534236469), 0);

            Assert.AreEqual(problem7.Reverse1(-2147483648), 0);

        }
    }
}
