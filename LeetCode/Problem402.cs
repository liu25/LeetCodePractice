using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Problem402
    {
        public string RemoveKdigits(string num, int k)
        {
            int l = num.Length;

            if (l == k)
                return "0";

            int p = l - k;

            var nums = num.ToCharArray();

            List<char> res = new List<char>();

            int index = 0;
            while (p > 0)
            {
                char temp = '9';

                for (int i = index; i <= l - p; i++)
                {
                    if (nums[i] < temp)
                    {
                        temp = nums[i];
                        index = i + 1;
                    }
                }

                res.Add(temp);
                p--;
            }

            while (res[0] == '0' && res.Count > 1)
            {
                res.RemoveAt(0);
            }

            return new string(res.ToArray());
        }
    }
}
