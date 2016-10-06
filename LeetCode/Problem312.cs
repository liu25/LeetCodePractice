using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem312
    {
        public int MaxCoins(int[] nums)
        {
            int n = nums.Length;

            int[] iNums = new int[n + 2];

            for (int i = 0; i < n; i++)
                iNums[i + 1] = nums[i];

            iNums[0] = iNums[n + 1] = 1;

            int[,] dp = new int[n + 2,n+2];

            return DP(1, n, iNums, dp);
        }

        private int DP(int i, int j, int[] iNums, int[,] dp)
        {
            if (dp[i,j] > 0)
                return dp[i,j];

            for (int x = i; x <= j; x++)
            {
                dp[i,j] = Math.Max(dp[i,j], DP(i, x - 1, iNums, dp) + iNums[i - 1] * iNums[x] * iNums[j + 1] + DP(x + 1, j, iNums, dp));
            }

            return dp[i,j];
        }

    }
}
