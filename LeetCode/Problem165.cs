using System;

namespace LeetCode
{
    public class Problem165
    {
        public int CompareVersion(string version1, string version2)
        {
            var version1List = version1.Split('.');

            var version2List = version2.Split('.');

            int maxLength = Math.Max(version1List.Length, version2List.Length);

            for (int i = 0; i < maxLength; i++)
            {
                int list1Version = GetVersion(version1List, i);

                int list2Version = GetVersion(version2List, i);

                int difference = list1Version - list2Version;

                if (difference > 0)
                    return 1;

                if (difference < 0)
                    return -1;
            }
            return 0;
        }

        private int GetVersion(string[] versionList, int i)
        {
            if (i >= versionList.Length)
            {
                return 0;
            }
            return Convert.ToInt32(versionList[i]);
        }
    }
}
