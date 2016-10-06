using System.Collections.Generic;

namespace LeetCode
{
    public class Problem70
    {
        public int ClimbStairs(int n)
        {
            if (n < 4)
                return n;

            int b = 3;

            int c = 5;

            for (int i = 5; i <= n; i++)
            {
                var tempC = c;

                c = b + c;

                b = tempC;
            }

            return c;
        }
    }
}
