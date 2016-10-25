using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem91
    {
        public int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int[] nums = new int[s.Length + 1];
            nums[0] = 1;
            nums[1] = s[0] != '0' ? 1 : 0;
            for (int i = 2; i <= s.Length; i++)
            {
                if (s[i - 1] != '0')
                {
                    nums[i] = nums[i - 1];
                }

                int twoDigits = (s[i - 2] - '0') * 10 + s[i - 1] - '0';
                if (twoDigits >= 10 && twoDigits <= 26)
                {
                    nums[i] += nums[i - 2];
                }
            }
            return nums[s.Length];
        }
    }
}
