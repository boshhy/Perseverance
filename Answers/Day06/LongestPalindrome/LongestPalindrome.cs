public class Solution
{
    // Define a public method named LongestPalindrome that takes a string parameter and returns an integer.
    public int LongestPalindrome(string s)
    {
        // Initialize a HashSet to store unique characters.
        HashSet<char> h = new HashSet<char>();

        // Initialize a variable to store the total length of the palindrome.
        int total = 0;

        // Iterate through each character in the input string.
        foreach (char letter in s)
        {
            // If the current character is already present in the HashSet.
            if (h.Contains(letter))
            {
                // Increase the total length by 2 since this character can be part of the palindrome.
                total = total + 2;

                // Remove the current character from the HashSet since it's already used in the palindrome.
                h.Remove(letter);
            }
            else
            {
                // If the current character is not present in the HashSet, add it.
                h.Add(letter);
            }
        }

        // If there are remaining characters in the HashSet after forming pairs, add 1 to the total length.
        return (h.Count > 0) ? total + 1 : total;
    }
}
