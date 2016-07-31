using System;

public class Problem16
{
  public int ThreeSumClosest(int[] nums, int target) {
    int closest = nums[0] + nums[1] + nums[2];
				
		Array.Sort(nums);
		
    for(int i = 0; i < nums.Length-2; i++)
		{		
			int start = i+1;
			
			int end = nums.Length-1;
			
			while(start < end)
			{
				int sum = nums[i]+nums[start]+nums[end];
				
				if(Math.Abs(target - closest) > Math.Abs(target - sum))
					closest = sum;
				
				if(sum < target)
					start++;
				else
					end--;
				
			}
		}
		return closest;
    }
}
