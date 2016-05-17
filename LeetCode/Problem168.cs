using System;

namespace LeetCode
{
    public class Problem168
    {
        public string ConvertToTitle(int n)
        {
            const int differnce = 26;
            const int decimalAMinus = 64;

            if (n <= 0)
                return "";

            int result = n/differnce;

            int mod = n%differnce;

            string modString;

            if (mod > 0)
            {
                modString = Convert.ToChar(mod + decimalAMinus).ToString();
            }
            else
            {
                result--;
                modString = Convert.ToChar(decimalAMinus  + differnce).ToString();
            }

            string denomiatorString = "";

            if (result > differnce)
            {
                denomiatorString = ConvertToTitle(result);
            }
            else if(result > 0)
            {
                if(mod == 0)
                {
                    denomiatorString = Convert.ToChar(result + decimalAMinus).ToString();
                }
                else
                {
                    denomiatorString = Convert.ToChar(result + decimalAMinus).ToString();
                }          
            }

            return denomiatorString + modString;
        }
    }
}
