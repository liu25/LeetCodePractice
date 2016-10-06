using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem312Test
    {
        [Test]
        public void TestMaxCoins()
        {
            Problem312 problem312 = new Problem312();

            int result = problem312.MaxCoins(new int[] {3, 1, 5, 8});

            Assert.AreEqual(result, 167);
        }
    }
}
