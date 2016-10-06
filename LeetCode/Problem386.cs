using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Problem386
    {
        public IList<int> LexicalOrder(int n)
        {
            int[] nums = new int[n];

            int cur = 1;
            for (int i = 0; i < n; i++)
            {
                nums[i] = cur;

                if (cur * 10 <= n)
                    cur *= 10;
                else
                {
                    if (cur >= n)
                        cur /= 10;
                    cur++;
                    while (cur % 10 == 0)
                        cur /= 10;
                }
            }

            return nums.ToList();
        }
    }
}
