using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem228
    {
        public IList<string> SummaryRanges(int[] nums)
        {            
            if (nums == null || nums.Length == 0)
                return new List<string>();

            IList<string> results = new List<string>();

            if (nums.Length == 1)
            {
                results.Add(nums[0].ToString());
                return results;
            }

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int current = nums[i];

                int next = nums[i + 1];

                long difference = next - (long) current;

                if (stack.Count == 0 || difference > 1)
                {
                    stack.Push(current);
                }

                if (difference > 1)
                {
                    results.Add(GetResult(stack));
                }

                if (i == (nums.Length - 2)) 
                {
                    stack.Push(nums[i + 1]);
                }
            }

            results.Add(GetResult(stack));

            return results;
        }

        private string GetResult(Stack<int> stack)
        {
            if (stack.Count == 1)
            {
                return stack.Pop().ToString();
            }
            int last = stack.Pop();
            int first = stack.Pop();
            return string.Format("{0}->{1}", first, last);
        }
    }
}
