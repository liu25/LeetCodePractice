using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem390
    {
        // 1 : 1
        // 1, 2: 2
        // 1, 2, 3: 2
        // 1, 2, 3, 4: 2
        // 1, 2, 3, 4, 5: 2
        // 1, 2, 3, 4, 5, 6: 2, 4, 6: 4
        // 1, 2, 3, 4, 5, 6, 7, 8: 2, 4, 6, 8: 2, 6: 6

        public int LastRemaining(int n)
        {
            return help(n, true);
        }
        int help(int n, bool left2Right)
        {
            if (n == 1) return 1;
            if (left2Right)
            {
                return 2 * help(n / 2, false);
            }
            return 2 * help(n / 2, true) - 1 + n % 2;
        }

        public int LastRemaining1(int n)
        {
            return n == 1 ? 1 : 2 * (1 + n / 2 - LastRemaining1(n / 2));
        }

        public int LastRemaining2(int n)
        {
            int b = 1, res = 1;
            while (b * 2 <= n)
            {
                res += b;
                b *= 2;
                if (b * 2 > n) break;
                if ((n / b) % 2 == 1) res += b;
                b *= 2;
            }
            return res;
        }
    }
}
