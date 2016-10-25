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
    class Problem39Test
    {
        [Test]
        public void TestCombinationSum()
        {
            Problem39 problem39 = new Problem39();

            var results = problem39.CombinationSum(new int[] {2, 3, 6, 7}, 7);
        }
    }
}
