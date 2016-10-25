using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem39
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> results = new List<IList<int>>();

            if (candidates == null)
                return results;

            List<int> path = new List<int>();

            var sortedCandidates = candidates.ToList();

            sortedCandidates.Sort();

            candidates = sortedCandidates.ToArray();

            FindAllCombinations(candidates, target, path, 0, results);

            return results;
        }

        private void FindAllCombinations(int[] candidates, int target, List<int> path, int index, IList<IList<int>> results)
        {
            if (target == 0)
            {
                results.Add(path.ToList());

                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                if (candidates[i] > target)
                    break;

                path.Add(candidates[i]);

                FindAllCombinations(candidates, target - candidates[i], path, i, results);

                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
