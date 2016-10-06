using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem202
    {
        public bool IsHappy(int n)
        {
            if (n <= 0)
                return false;

            HashSet<int> allNumbers = new HashSet<int>();

            while (true)
            {
                if (allNumbers.Contains(n))
                    return false;
                allNumbers.Add(n);

                n = GetDigitsSquareSum(n);

                if (n == 1)
                    return true;
            }
        }

        private int GetDigitsSquareSum(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;

                n = n / 10;

                sum = sum + digit * digit;
            }

            return sum;
        }
    }
}
