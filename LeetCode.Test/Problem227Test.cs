using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem227Test
    {
        [Test]
        public void TestCalculate()
        {
            Problem227 problem227 = new Problem227();

            Assert.AreEqual(2, problem227.Calculate("1 + 1"));

            Assert.AreEqual(4, problem227.Calculate("1 + 1*3"));
        }
    }
}
