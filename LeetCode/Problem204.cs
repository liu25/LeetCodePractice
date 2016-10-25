using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem204
    {
        public int CountPrimes(int n)
        {
            bool[] primes = new bool[n + 1];

            for (int i = 0; i <= n; i++)
                primes[i] = true;

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    for (int j = i * 2; j < n; j = j + i)
                    {
                        primes[j] = false;
                    }
                }
            }

            int count = 0;

            for (int i = 2; i < n; i++)
            {
                if (primes[i])
                    count++;
            }

            return count;
        }
    }
}
