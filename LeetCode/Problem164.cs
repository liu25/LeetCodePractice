using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem164
    {
        public int MaximumGap(int[] nums)
        {
            if (nums == null)
                return -1;

            if (nums.Length < 2)
                return 0;

            var sorted = nums.ToList();

            sorted.Sort();

            int maxDistance = 0;

            for (int i = 0; i < sorted.Count - 1; i++)
            {
                int distance = Math.Abs(sorted[i] - sorted[i + 1]);

                if (maxDistance < distance)
                    maxDistance = distance;
            }

            return maxDistance;
        }
    }
}
