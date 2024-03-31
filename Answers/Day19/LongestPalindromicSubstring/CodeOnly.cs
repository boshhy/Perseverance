public class Solution
{
    public string LongestPalindrome(string s)
    {
        int starting = 0;
        int maxLength = 1;

        for (int index = 0; index < s.Length; index++)
        {
            IsPalindrome(index, index);
            IsPalindrome(index, index + 1);
        }

        return s.Substring(starting, maxLength);

        void IsPalindrome(int left, int right)
        {
            while (left >= 0 && right < s.Length)
            {
                if (s[left] == s[right])
                {
                    if (right - left + 1 > maxLength)
                    {
                        starting = left;
                        maxLength = right - left + 1;
                    }
                }
                else
                {
                    return;
                }
                left--;
                right++;
            }
        }
    }
}