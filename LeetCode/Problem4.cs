using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int num1Index = 0;

            int num2Index = 0;

            int[] nums3 = new int[nums1.Length + nums2.Length];

            for (int i = 0; i < nums1.Length + nums2.Length; i++)
            {
                if (num1Index >= nums1.Length)
                {
                    nums3[i] = nums2[num2Index];
                    num2Index++;
                }
                else if (num2Index >= nums2.Length)
                {
                    nums3[i] = nums1[num1Index];
                    num1Index++;
                }
                else if (nums1[num1Index] > nums2[num2Index])
                {
                    nums3[i] = nums2[num2Index];
                    num2Index++;
                }
                else
                {
                    nums3[i] = nums1[num1Index];
                    num1Index++;
                }
            }

            double median;

            if (nums3.Length%2 == 0)
            {
                median = (nums3[nums3.Length/2] + nums3[nums3.Length/2 - 1])/(double) 2;
            }
            else
            {
                median = nums3[(nums3.Length - 1)/2];
            }

            return median;
        }
    }
}
