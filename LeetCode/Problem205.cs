using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem205
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s == null || t == null)
                return false;

            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, char> sourceMap = new Dictionary<char, char>();
            Dictionary<char, char> targetMap = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!CheckMap(sourceMap, s[i], t[i]))
                    return false;

                if (!CheckMap(targetMap, t[i], s[i]))
                    return false;
            }

            return true;
        }

        private bool CheckMap(Dictionary<char, char> map, char a, char b)
        {
            if (map.ContainsKey(a) && map[a] != b)
            {
                return false;
            }

            if (!map.ContainsKey(a))
            {
                map.Add(a, b);
            }

            return true;
        }
    }
}
