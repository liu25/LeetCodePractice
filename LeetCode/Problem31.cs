using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Problem31
    {
        public void NextPermutation(int[] nums)
	{
		int length = nums.Length -1;
		
    	while(length > 0)
		{
			if(nums[length] > nums[length-1])
				break;
			length--;
		}
		
		if(length == 0)
		{
			int lower = 0;
			
			int upper = nums.Length-1;
			
			while(lower < upper)
			{
				Swap(nums, lower, upper);
				lower++;
				upper--;
			}
			
			return;
		}									
		
		Array.Sort(nums, length, nums.Length-length);				
		
		FindAndSwap(nums, length-1, length, nums.Length-1);
	}

	public void FindAndSwap(int[] nums, int valueIndex, int start, int end)
	{				
		if(end == start)
		{			
			Swap(nums, start, valueIndex);			
			return;
		}
		
		int mid = (end + start)/2;
		
		if(nums[mid] <= nums[valueIndex])
		{
			FindAndSwap(nums, valueIndex, mid+1, end);
		}
		else
		{
			FindAndSwap(nums, valueIndex, start, mid);
		}
	}
	
	public void Swap(int[] nums, int index1, int index2)
	{
		int temp = nums[index1];
		
		nums[index1] = nums[index2];
		
		nums[index2] = temp;
	}
    }
}
