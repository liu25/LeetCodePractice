using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LeetCode
{
    public class Problem7
    {
        public int Reverse(int x)
        {
            int multiplier = x >= 0 ? 1 : -1;

            string s = (Math.Abs((long)x)).ToString();

            char[] sr = new char[s.Length];

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sr[s.Length -1- i] = s[i];
            }

            long result = multiplier*Convert.ToInt64(new string(sr));

            return result > Int32.MaxValue || result < Int32.MinValue ? 0 : (int)result;
        }

        public int Reverse1(int x)
        {
            long xx = x;

            long res = 0;

            while (xx != 0)
            {
                res = res*10 + xx%10;

                xx /= 10;
            }

            if (res > Int32.MaxValue || res < Int32.MinValue)
                return 0;

            return (int)res;
        }
    }
}
