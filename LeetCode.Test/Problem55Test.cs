using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem55Test
    {
        [Test]
        public void TestCanJump()
        {
            Problem55 problem55 = new Problem55();

            Assert.IsTrue(problem55.CanJump(new[] {2, 0, 0}));
        }
    }
}
