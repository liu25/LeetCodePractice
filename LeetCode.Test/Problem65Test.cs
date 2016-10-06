using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem65Test
    {
        [Test]
        public void TestIsNumber()
        {
            Problem65 problem65 = new Problem65();

            Assert.AreEqual(problem65.IsNumber("."), false);
        }
    }
}
