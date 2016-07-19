using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            if (strs.Length == 1)
                return strs[0];

            string commonPrefix = null;
            for (int i = 0; i < strs.Length -1; i++)
            {
                string s1;
                if (commonPrefix == null)
                    s1 = strs[i];
                else
                {
                    s1 = commonPrefix;
                }

                string s2 = strs[i + 1];

                int minLength = Math.Min(s1.Length, s2.Length);
                if (minLength == 0)
                    return "";

                int j = 0;
                for ( ;j < minLength; j++)
                {
                    if (s1[j] != s2[j])
                    {
                        commonPrefix = s1.Substring(0, j);
                        break;
                    }
                }

                if (j == minLength)
                {
                    commonPrefix = s1.Substring(0, j);
                }
            }

            return commonPrefix;
        }
    }
}
