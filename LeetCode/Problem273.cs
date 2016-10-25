using System;
using System.Text;

namespace LeetCode
{
    public class Problem273
    {
        public string NumberToWords(int num)
        {
            if (num == 0)
                return "Zero";

            int bil = num/1000000000;
            int bilRemain = num%1000000000;
            int mil = bilRemain / 1000000;
            int milRemain = bilRemain % 1000000;
            int tho = milRemain/1000;
            int hun = milRemain % 1000;

            StringBuilder sb = new StringBuilder();

            if (bil > 0)
                AppendWithSpace(sb, GetString(bil) + " Billion");
            if (mil > 0)
                AppendWithSpace(sb, GetString(mil) + " Million");
            if (tho > 0)
                AppendWithSpace(sb, GetString(tho) + " Thousand");
            if (hun > 0)
                AppendWithSpace(sb, GetString(hun));

            return sb.ToString();
        }

        private string GetString(int num)
        {
            StringBuilder sb = new StringBuilder();

            int hun = num/100;
            if (hun > 0)
                AppendWithSpace(sb, DigitToWord(hun) + " Hundred");
            int hunRemain = num % 100;
            if (hunRemain > 0)
                AppendWithSpace(sb, TensToString(hunRemain));

            return sb.ToString();
        }

        private string TensToString(int hunRemain)
        {
            StringBuilder sb = new StringBuilder();
            int tens = hunRemain / 10;
            int digit = hunRemain % 10;
            if (tens > 1)
            {
                AppendWithSpace(sb, DigitToTens(tens));
                if (digit > 0)
                {
                    AppendWithSpace(sb, DigitToWord(digit));
                }
            }
            else
            {
                if (tens == 1)
                {
                    AppendWithSpace(sb, TeensToWord(hunRemain));
                }
                else
                {
                    AppendWithSpace(sb, DigitToWord(digit));
                }
            }

            return sb.ToString();
        }

        private string TeensToWord(int hunRemain)
        {
            if (hunRemain == 10)
                return "Ten";
            if (hunRemain == 11)
                return "Eleven";
            if (hunRemain == 12)
                return "Twelve";
            if (hunRemain == 13)
                return "Thirteen";
            if (hunRemain == 14)
                return "Fourteen";
            if (hunRemain == 15)
                return "Fifteen";
            if (hunRemain == 16)
                return "Sixteen";
            if (hunRemain == 17)
                return "Seventeen";
            if (hunRemain == 18)
                return "Eighteen";
            if (hunRemain == 19)
                return "Nineteen";

            throw new ArgumentOutOfRangeException("Must be 10 to 19");
        }

        private string DigitToTens(int digit)
        {
            if (digit == 2)
                return "Twenty";
            if (digit == 3)
                return "Thirty";
            if (digit == 4)
                return "Forty";
            if (digit == 5)
                return "Fifty";
            if (digit == 6)
                return "Sixty";
            if (digit == 7)
                return "Seventy";
            if (digit == 8)
                return "Eighty";
            if (digit == 9)
                return "Ninety";

            throw new ArgumentOutOfRangeException("Must be 2 to 9");
        }

        private string DigitToWord(int digit)
        {
            if (digit == 1)
                return "One";
            if (digit == 2)
                return "Two";
            if (digit == 3)
                return "Three";
            if (digit == 4)
                return "Four";
            if (digit == 5)
                return "Five";
            if (digit == 6)
                return "Six";
            if (digit == 7)
                return "Seven";
            if (digit == 8)
                return "Eight";
            if (digit == 9)
                return "Nine";

            throw new ArgumentOutOfRangeException("Must be 1 to 9");
        }

        private void AppendWithSpace(StringBuilder sb, string s)
        {
            if (sb.Length > 0)
                sb.Append(" " + s);
            else
                sb.Append(s);
        }
    }
}
