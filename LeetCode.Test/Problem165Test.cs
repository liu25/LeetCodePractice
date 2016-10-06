using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem165Test
    {
        [Test]
        public void TestCompareVersion()
        {
            string version1Same = "0.1.0";
            string version1 = "0.1";
            string version2 = "1.1";
            string version3 = "1.2";
            string version4 = "1.3.37";
            string version5 = "13.37";

            Problem165 problem165 = new Problem165();

            Assert.AreEqual(problem165.CompareVersion(version1, version1), 0);

            Assert.AreEqual(problem165.CompareVersion(version1, version2), -1);

            Assert.AreEqual(problem165.CompareVersion(version2, version1), 1);

            Assert.AreEqual(problem165.CompareVersion(version3, version4), -1);

            Assert.AreEqual(problem165.CompareVersion(version4, version3), 1);

            Assert.AreEqual(problem165.CompareVersion(version4, version5), -1);

            Assert.AreEqual(problem165.CompareVersion(version1, version1Same), 0);
        }
    }
}
