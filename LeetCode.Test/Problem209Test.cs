using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    public class Problem209Test
    {
        [Test]
        public void TestMinSubArrayLen()
        {
            Problem209 problem209 = new Problem209();

            var res = problem209.MinSubArrayLen(7, new int[] {2, 3, 1, 2, 4, 3});

            Assert.AreEqual(res, 2);
        }
    }
}
