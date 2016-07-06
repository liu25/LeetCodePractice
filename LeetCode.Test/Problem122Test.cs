using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem122Test
    {
        [Test]
        public void TestMaxProfit()
        {
            Problem122 problem122 = new Problem122();

            Assert.AreEqual(problem122.MaxProfit(new int[] { 1, 5 ,6 ,3 ,2 ,9 ,10}), 13);

            Assert.AreEqual(problem122.MaxProfit(new int[] { 2, 1, 2, 0, 1 }), 2);
        }
    }
}
