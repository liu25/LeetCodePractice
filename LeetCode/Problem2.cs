using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem2
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int[] res = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }

                int temp = target - nums[i];

                if (dict.ContainsKey(temp) && dict[temp] != i)
                {
                    if (dict[temp] > i)
                    {
                        res[0] = i;
                        res[1] = dict[temp];
                    }
                    else
                    {
                        res[0] = dict[temp];
                        res[1] = i;
                    }
                    break;
                }
            }

            return res;
        }
    }
}
