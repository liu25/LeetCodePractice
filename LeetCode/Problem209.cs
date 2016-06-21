using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem209
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            if (nums == null || nums.Length == 1)
                return 0;

            int currSum = 0, minLen = nums.Length + 1;

            // Initialize starting and ending indexes
            int start = 0, end = 0;
            while (end < nums.Length)
            {
                // Keep adding array elements while current sum
                // is smaller than x
                while (currSum < s && end < nums.Length)
                    currSum += nums[end++];

                // If current sum becomes greater than x.
                while (currSum >= s && start < nums.Length)
                {
                    // Update minimum length if needed
                    if (end - start < minLen)
                        minLen = end - start;

                    // remove starting elements
                    currSum -= nums[start++];
                }
            }

            if(minLen <= nums.Length)
                return minLen;
            return 0;
        }

        private int Sum(int[] nums, int start, int end)
        {
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                sum += nums[start];
            }

            return sum;
        }
    }
}
