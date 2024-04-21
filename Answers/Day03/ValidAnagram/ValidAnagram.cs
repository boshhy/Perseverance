public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // If the lengths of the two strings are not equal, they cannot be anagrams 
        if (s.Length != t.Length)
        {
            return false;
        }

        // Array to store the count of each character in the strings
        int[] count = new int[26];

        // Iterate through the characters of both strings
        for (int i = 0; i < s.Length; i++)
        {
            // Increment count for the character in string s and decrement count for the character in string t
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        // Check if all counts are zero, indicating that both strings have the same characters with the same frequency
        foreach (int total in count)
        {
            if (total != 0)
            {
                // If any count is not zero, the strings are not anagrams
                return false;
            }
        }

        // If all counts are zero, the strings are anagrams
        return true;
    }
}
