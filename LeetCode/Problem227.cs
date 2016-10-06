using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem227
    {
        public int Calculate(string s)
        {
            int res = 0, d = 0;
            char sign = '+';
            Stack<int> nums = new Stack<int>();
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] >= '0')
                {
                    d = d * 10 + s[i] - '0';
                }

                if ((s[i] < '0' && s[i] != ' ') || i == s.Length - 1)
                {
                    if (sign == '+') nums.Push(d);
                    if (sign == '-') nums.Push(-d);
                    if (sign == '*' || sign == '/')
                    {
                        int top = nums.Pop();
                        int tmp = sign == '*' ? top * d : top / d;
                        nums.Push(tmp);
                    }
                    sign = s[i];
                    d = 0;
                }
            }
            while (nums.Any())
            {
                res += nums.Pop();
            }
            return res;
        }
    }
}
