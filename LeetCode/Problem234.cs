using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem234
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }
        }

        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return true;

            List<int> values = new List<int>();

            var start = head;

            while (start != null)
            {
                values.Add(start.val);

                start = start.next;
            }

            for (int i = 0; i <= values.Count / 2; i++)
            {
                if (values[i] != values[values.Count - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
