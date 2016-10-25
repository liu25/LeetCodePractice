using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem13Test
    {
        [Test]
        public void TestRomanToInt()
        {
            Problem13 problem13 = new Problem13();

            Assert.AreEqual(problem13.RomanToInt("XLIII"), 43);

            Assert.AreEqual(problem13.RomanToInt("XXIX"), 29);

            Assert.AreEqual(problem13.RomanToInt("XCVIII"), 98);
        }
    }
}
