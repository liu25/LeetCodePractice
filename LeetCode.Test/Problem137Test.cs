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
    class Problem137Test
    {
        [Test]
        public void TestSingleNumber2()
        {
            Problem137 problem137 = new Problem137();

            var result1 = problem137.SingleNumber(new int[]
            {
                1
            });

            Assert.AreEqual(result1, 1);

            var result2 = problem137.SingleNumber(new int[]
            {
                1, 1, 1, 2, 2, 2, 3
            });

            Assert.AreEqual(result2, 3);
        }
    }
}
