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
    class Prodblem152Test
    {
        [Test]
        public void TestMaxProduct()
        {
            Problem152 problem152 = new Problem152();

            Assert.AreEqual(problem152.MaxProduct(new[] {2, 3, -2, 4}), 6);

            Assert.AreEqual(problem152.MaxProduct(new[] { -1, 2, 3 -4, 2 ,0, 2, -1, 3, -4 , -5 }), 60);
        }
    }
}
