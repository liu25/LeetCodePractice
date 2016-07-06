using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem166
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            if (denominator == 0)
                return "";
            if (numerator == 0)
                return "0";

            string result = string.Empty;

            if (numerator < 0 ^ denominator < 0)
            {
                result += "-";
            }

            long n = numerator,d = denominator;

            n = Math.Abs(n);
            d = Math.Abs(d);

            long bd = n/d;

            result += bd.ToString();

            long r = (n%d)*10;

            if (r == 0)
                return result;

            result += ".";

            Dictionary<long, int> dict = new Dictionary<long, int>();

            while (r != 0)
            {
                if (dict.ContainsKey(r))
                {
                    result = result.Substring(0, dict[r]) + "(" + result.Substring(dict[r]) + ")";

                    return result;
                }

                dict.Add(r, result.Length);

                bd = r/d;

                result += bd;

                r = r%d*10;
            }

            return result;
        }
    }
}
