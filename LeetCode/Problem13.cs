using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem13
    {
        public int RomanToInt(string s)
        {
            int i = 0;

            int res = 0;

            while (i < s.Length)
            {
                int nextValue = i < s.Length - 1 ? RomanLetterToInt(s[i + 1]) : 0;

                int currValue = RomanLetterToInt(s[i]);

                int multiplier = currValue >= nextValue ? 1 : -1;

                res += multiplier*currValue;

                i++;
            }

            return res;
        }

        private int RomanLetterToInt(char romanLetter)
        {
            switch (romanLetter)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
