﻿namespace LeetCode
{
    public class Problem55
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length <= 1)
                return true;

            int max = nums[0]; //max stands for the largest index that can be reached.

            for (int i = 0; i < nums.Length; i++)
            {
                //if not enough to go to next
                if (max <= i && nums[i] == 0)
                    return false;

                //update max    
                if (i + nums[i] > max)
                {
                    max = i + nums[i];
                }

                //max is enough to reach the end
                if (max >= nums.Length - 1)
                    return true;
            }

            return false;
        }
    }
}
