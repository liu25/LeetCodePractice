using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem152
    {
        public int MaxProduct(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return nums[0];

            int[] products = new int[nums.Length];
            int counter = 0;

            int negative = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    negative = 0;

                    counter++;
                }

                if (nums[i] > 0)
                {
                    if (products[counter] == 0)
                        products[counter] += nums[i];
                    else
                    {
                        products[counter] *= nums[i];
                    }
                }

                if (nums[i] < 0)
                {
                    // If there is already a negative before
                    if (negative < 0)
                    {
                        products[counter - 1] = products[counter - 1]*negative*nums[i]*products[counter];

                        negative = 0;

                        products[counter] = 0;

                        counter--;
                    }
                    else
                    {
                        negative = nums[i];

                        counter++;
                    }
                }
            }

            return products.Max();
        }
    }
}
