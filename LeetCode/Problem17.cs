using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem17
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrWhiteSpace(digits))
                return new List<string>();

            Dictionary<int, string> map = GetMapping();

            List<string> results = new List<string>();

            StringBuilder currentCombination = new StringBuilder();

            GetCombinations(results, currentCombination, digits, map);

            return results;
        }        

        private Dictionary<int, string> GetMapping()
        {
            return new Dictionary<int, string>
            {
                {2, "abc"},
                {3, "def"},
                {4, "ghi"},
                {5, "jkl"},
                {6, "mno"},
                {7, "pqrs"},
                {8, "tuv"},
                {9, "wxyz"}
            };
        }

        private void GetCombinations(List<string> results, StringBuilder currentCombination, string digits, Dictionary<int, string> map)
        {
            if (digits.Length == 0)
            {
                results.Add(currentCombination.ToString());
                return;
            }

            var current = Convert.ToInt16(digits.Substring(0, 1));

            string letters = map[current];

            for (int i = 0; i < letters.Length; i++)
            {
                currentCombination.Append(letters[i]);

                GetCombinations(results, currentCombination, digits.Substring(1), map);

                currentCombination.Remove(currentCombination.Length - 1, 1);
            }
        }
    }
}
