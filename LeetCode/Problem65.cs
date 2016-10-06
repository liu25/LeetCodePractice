namespace LeetCode
{
    public class Problem65
    {
        public bool IsNumber(string s)
        {
            int len = s.Length;
            int i = 0, e = len - 1;
            while (i <= e && char.IsWhiteSpace(s[i]))
                i++;
            if (i > len - 1) return false;
            while (e >= i && char.IsWhiteSpace(s[e]))
                e--;

            // skip leading +/-
            if (s[i] == '+' || s[i] == '-')
                i++;

            bool num = false; // is a digit
            bool dot = false; // is a '.'
            bool exp = false; // is a 'e'
            while (i <= e)
            {
                char c = s[i];
                if (char.IsDigit(c))
                {
                    num = true;
                }
                else if (c == '.')
                {
                    if (exp || dot) return false;
                    dot = true;
                }
                else if (c == 'e')
                {
                    if (exp || num == false) return false;
                    exp = true;
                    num = false;
                }
                else if (c == '+' || c == '-')
                {
                    if (s[i - 1] != 'e') return false;
                }
                else
                {
                    return false;
                }
                i++;
            }
            return num;
        }
    }
}
