using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Problem394
    {
        public string DecodeString(string s)
        {
            string cur = "";
            Stack<int> counts = new Stack<int>();
            Stack<string> strs = new Stack<string>();
            int i = 0;
            while (i < s.Length)
            {
                if (char.IsDigit(s[i]))
                {
                    int num = s[i] - '0';
                    while (char.IsDigit(s[++i]))
                    {
                        num = num * 10 + (s[i] - '0');
                    }
                    counts.Push(num);
                }
                else if (s[i] == '[')
                {
                    strs.Push(cur);
                    cur = "";
                    i++;
                }
                else if (s[i] == ']')
                {
                    StringBuilder str = new StringBuilder(strs.Pop());
                    int count = counts.Pop();
                    for (int j = 0; j < count; j++)
                    {
                        str.Append(cur);
                    }
                    cur = str.ToString();
                    i++;
                }
                else
                {
                    cur += s[i++];
                }
            }
            return cur;
        }
    }
}
