using System;
using System.Linq;

namespace LeetCode
{
    public class Problem319
    {
        public int BulbSwitch(int n)
        {
            if (n == 0 || n == 1)
                return n;

            bool[] bulbs = new bool[n];

            for (int i = 0; i < n; i++)
            {
                bulbs[i] = true;
            }

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j*i <= n; j++)
                {
                    bulbs[j*i - 1] = !bulbs[j*i - 1];
                }
            }

            return bulbs.Where(b => b).Count();
        }

        public int BulbSwitchV1(int n)
        {
            if (n == 0 || n == 1)
                return n;

            return (int)Math.Sqrt(n);
        }
    }
}
