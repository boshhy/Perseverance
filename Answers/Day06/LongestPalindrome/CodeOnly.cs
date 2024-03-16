public class Solution
{
    public int LongestPalindrome(string s)
    {
        HashSet<char> h = new HashSet<char>();
        int total = 0;

        foreach (char letter in s)
        {
            if (h.Contains(letter))
            {
                total = total + 2;
                h.Remove(letter);
            }
            else
            {
                h.Add(letter);
            }
        }

        return (h.Count > 0) ? total + 1 : total;
    }
}