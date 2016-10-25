using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Problem349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, bool> existsInFirst = new Dictionary<int, bool>();
            foreach (int num in nums1)
            {
                if (!existsInFirst.ContainsKey(num))
                    existsInFirst.Add(num, false);
            }

            foreach (int num in nums2)
            {
                if (existsInFirst.ContainsKey(num))
                {
                    existsInFirst[num] = true;
                }
            }

            return existsInFirst.Where(e => e.Value).Select(t => t.Key).ToArray();
        }
    }
}
