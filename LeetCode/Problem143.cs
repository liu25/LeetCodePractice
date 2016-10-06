using System.Collections.Generic;

namespace LeetCode
{
    public class Problem143
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


        public void ReorderList(ListNode head)
        {
            Dictionary<int, ListNode> nodesDictionary = new Dictionary<int, ListNode>();

            var node = head;

            int counter = 0;
            while (node != null)
            {
                nodesDictionary.Add(counter++, node);

                node = node.next;
            }
            
            counter = 0;
            while (counter < nodesDictionary.Count)
            {
                if (counter%2 == 0)
                {
                    head = nodesDictionary[counter/2];

                    head.next = nodesDictionary[nodesDictionary.Count - 1 - counter];
                }
                else
                {
                    head.next = nodesDictionary[(counter + 1)/2];
                }

                head = head.next;
                counter++;
            }

            head.next = null;
        }
    }
}
