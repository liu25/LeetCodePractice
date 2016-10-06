using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem62
    {
        public int UniquePaths(int m, int n)
        {
            if (m < 1 && n < 1)
                return 0;

            int[,] dp = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                dp[i, 0] = 1;
            }

            for (int j = 0; j < n; j++)
            {
                dp[0, j] = 1;
            }

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }

            return dp[m - 1, n - 1];
        }
    }
}
