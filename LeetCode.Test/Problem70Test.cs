using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem70Test
    {
        [Test]
        public void TestClimbStairs()
        {
            Problem70 problem70 = new Problem70();

            int value = problem70.ClimbStairs(44);
        }
    }
}
