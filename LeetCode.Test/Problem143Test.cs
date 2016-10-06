using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    class Problem143Test
    {
        [Test]
        public void TestReorderList()
        {
            Problem143 problem143 = new Problem143();

            var list = new Problem143.ListNode(1)
            {
                next = new Problem143.ListNode(2)
                {
                    next = new Problem143.ListNode(3)
                }
            };

            problem143.ReorderList(list);

            int counter = 0;
            while (list != null)
            {
                if(counter == 0)
                    Assert.AreEqual(list.val, 1);

                if (counter == 1)
                    Assert.AreEqual(list.val, 3);

                if (counter == 2)
                    Assert.AreEqual(list.val, 2);

                list = list.next;
                counter++;
            }
        }
    }
}
