public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> d = new Dictionary<char, int>();
        foreach (char letter in magazine)
        {
            if (d.ContainsKey(letter))
            {
                d[letter]++;
            }
            else
            {
                d[letter] = 1;
            }
        }

        foreach (char letter in ransomNote)
        {
            if (!d.ContainsKey(letter))
            {
                return false;
            }
            if (--d[letter] < 0)
            {
                return false;
            }
        }
        return true;
    }
}