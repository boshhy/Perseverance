public class Solution
{
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            char leftChar = s[left];
            char rightChar = s[right];

            if (!char.IsLetterOrDigit(leftChar))
            {
                left++;
                continue;
            }
            if (!char.IsLetterOrDigit(rightChar))
            {
                right--;
                continue;
            }
            if (leftChar != rightChar)
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
