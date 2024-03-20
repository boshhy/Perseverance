public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int max = 0;
        int left = 0;
        int current = 0;

        HashSet<char> hashSet = new HashSet<char>();

        for (int right = 0; right < s.Length; right++)
        {
            if (hashSet.Contains(s[right]))
            {
                while (s[left] != s[right])
                {
                    hashSet.Remove(s[left]);
                    left++;
                    current--;
                }
                left++;
            }
            else
            {
                current++;
                hashSet.Add(s[right]);
                max = Math.Max(max, current);
            }
        }

        return max;
    }
}