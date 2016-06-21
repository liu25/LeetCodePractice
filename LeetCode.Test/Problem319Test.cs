using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem319Test
    {
        [Test]
        public void TestBulbSwitch()
        {
            Problem319 problem319 = new Problem319();

            Assert.AreEqual(1, problem319.BulbSwitch(3));

            Assert.AreEqual(2, problem319.BulbSwitch(4));

            Assert.AreEqual(2, problem319.BulbSwitch(99999999));
            
        }
    }
}
