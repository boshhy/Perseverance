public class Solution
{
    public int MyAtoi(string s)
    {
        s = s.Trim();

        if (s.Length == 0) return 0;
        bool isPositive = true;
        int skip = 0;

        if (s[0] == '-' || s[0] == '+')
        {
            skip++;
            if (s[0] == '-')
            {
                isPositive = false;
            }
        }
        else if (!char.IsNumber(s[0]))
        {
            return 0;
        }

        int total = 0;
        int currentDigit;
        int maxDiv10 = int.MaxValue / 10;

        foreach (char character in s.Skip(skip))
        {
            if (char.IsNumber(character))
            {
                currentDigit = character - '0';

                if (total > maxDiv10 || (total == maxDiv10 && currentDigit >= 8))
                {
                    return isPositive ? int.MaxValue : int.MinValue;
                }

                total = total * 10 + currentDigit;
            }
            else
            {
                break;
            }
        }

        return isPositive ? total : -total;
    }
}