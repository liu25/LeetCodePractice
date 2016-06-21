using System.Text;

namespace LeetCode
{
    public class Problem316
    {
        public string RemoveDuplicateLetters(string s)
        {
            int[] letterCounter = new int[26];
            foreach (char letter in s)
                letterCounter[letter - 'a']++;

            bool[] onStack = new bool[26];
            char[] a = new char[s.Length + 1];
            int sz = 0;
            foreach (char letter in s)
            {
                letterCounter[letter - 'a']--;

                if (onStack[letter - 'a'])
                {
                    continue;
                }

                while (sz != 0 && a[sz] >= letter && letterCounter[a[sz] - 'a'] > 0)
                {
                    onStack[a[sz] - 'a'] = false;
                    sz--;
                }
                ++sz;
                a[sz] = letter;
                onStack[a[sz] - 'a'] = true;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= sz; i++)
                sb.Append(a[i]);
            return sb.ToString();
        }
    }
}
