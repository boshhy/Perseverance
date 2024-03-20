public class Solution
{
    // This method calculates the length of the longest substring without repeating characters.
    public int LengthOfLongestSubstring(string s)
    {
        // Initialize variables to keep track of the maximum length, left pointer, and current length.
        int max = 0;        // Maximum length of substring without repeating characters.
        int left = 0;       // Left pointer of the current substring.
        int current = 0;    // Length of the current substring without repeating characters.

        // HashSet to store characters of the current substring.
        HashSet<char> hashSet = new HashSet<char>();

        // Loop through the string to find the longest substring without repeating characters.
        for (int right = 0; right < s.Length; right++)
        {
            // If the current character is already present in the HashSet, indicating repetition.
            if (hashSet.Contains(s[right]))
            {
                // Move the left pointer until the substring becomes unique again.
                while (s[left] != s[right])
                {
                    // Remove the leftmost character from the HashSet and update current length.
                    hashSet.Remove(s[left]);
                    left++;
                    current--;
                }
                // Move the left pointer to the next character to continue the search.
                left++;
            }
            else
            {
                // If the current character is unique, add it to the HashSet and update current length.
                current++;
                hashSet.Add(s[right]);
                // Update the maximum length encountered so far.
                max = Math.Max(max, current);
            }
        }

        // Return the length of the longest substring without repeating characters.
        return max;
    }
}
