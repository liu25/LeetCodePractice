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
    class Problem142Test
    {
        [Test]
        public void TestDetectCycle()
        {
            Problem142 problem142 = new Problem142();

            var result = problem142.DetectCycle(GetListNode());

            Assert.AreEqual(result.val, 1);
        }

        private Problem142.ListNode GetListNode()
        {
            var head = new Problem142.ListNode(1);

            head.next = new Problem142.ListNode(3)
            {
                next = new Problem142.ListNode(2)
                {
                    next = new Problem142.ListNode(1)
                    {
                        next = new Problem142.ListNode(5)
                        {
                            next = head
                        }
                    }
                }
            };

            return head;
        }
    }
}
