using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem142
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }

            var fast = head.next;

            var slow = head;

            while (fast != slow)
            {
                if (fast.next == null || fast.next.next == null)
                {
                    return null;
                }
                fast = fast.next.next;
                slow = slow.next;
            }

            while (head != fast.next)
            {
                head = head.next;
                fast = fast.next;
            }

            return head;
        }
    }
}
