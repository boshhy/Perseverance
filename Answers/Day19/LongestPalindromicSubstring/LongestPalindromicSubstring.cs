public class Solution
{
    public string LongestPalindrome(string s)
    {
        // Initialize variables to keep track of the starting index and maximum length of palindrome
        int starting = 0;
        int maxLength = 1;

        // Iterate through each character in the string
        for (int index = 0; index < s.Length; index++)
        {
            // Check for palindromes with the current character as the center (odd length palindrome)
            IsPalindrome(index, index);
            // Check for palindromes with the current character and the next character as the center (even length palindrome)
            IsPalindrome(index, index + 1);
        }

        // Return the longest palindrome substring
        return s.Substring(starting, maxLength);

        // Method to check if a substring is a palindrome, with given left and right indices
        void IsPalindrome(int left, int right)
        {
            // Loop until left index is greater than or equal to 0 and right index is less than string length
            while (left >= 0 && right < s.Length)
            {
                // If characters at left and right indices match
                if (s[left] == s[right])
                {
                    // If the length of current palindrome substring is greater than the maximum length found so far
                    if (right - left + 1 > maxLength)
                    {
                        // Update starting index and maximum length
                        starting = left;
                        maxLength = right - left + 1;
                    }
                }
                else
                {
                    // If characters don't match, break the loop (substring is not a palindrome)
                    return;
                }

                // Move to the adjacent characters towards both ends
                left--;
                right++;
            }
        }
    }
}
