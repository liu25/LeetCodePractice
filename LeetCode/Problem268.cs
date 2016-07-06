using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem268
    {
        public int MissingNumber(int[] nums)
        {
            bool[] appearance = new bool[nums.Length + 1];

            foreach (int num in nums)
            {
                appearance[num] = true;
            }

            for (int i = 0; i < appearance.Length; i++)
            {
                if (!appearance[i])
                    return i;
            }

            return -1;
        }
    }
}
