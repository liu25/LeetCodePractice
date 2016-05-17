using System.Collections.Generic;

namespace LeetCode
{
    public class Problem242
    {
        public bool IsAnagram(string source, string target)
        {
            if (source == null ||
                target == null)
                return false;

            if (source.Length != target.Length)
            {
                return false;
            }

            Dictionary<char, int> letterAppearanceDictionary = new Dictionary<char, int>();

            foreach (var sourceChar in source.ToCharArray())
            {
                if (letterAppearanceDictionary.ContainsKey(sourceChar))
                {
                    letterAppearanceDictionary[sourceChar]++;
                }
                else
                {
                    letterAppearanceDictionary.Add(sourceChar, 1);
                }
            }

            foreach (var targetChar in target.ToCharArray())
            {
                if (letterAppearanceDictionary.ContainsKey(targetChar))
                {
                    letterAppearanceDictionary[targetChar]--;
                }
                else
                {
                    return false;
                }
            }

            foreach (var charAppearancePair in letterAppearanceDictionary)
            {
                if (charAppearancePair.Value != 0)
                    return false;
            }

            return true;
        }
    }
}
