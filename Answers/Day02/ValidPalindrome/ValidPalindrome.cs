public class Solution
{
    public bool IsPalindrome(string s)
    {
        // Convert the input string to lowercase to ignore case differences 
        s = s.ToLower();

        // Initialize pointers for the leftmost and rightmost characters
        int left = 0;
        int right = s.Length - 1;

        // Loop until the left pointer crosses the right pointer
        while (left < right)
        {
            // Get the characters at the left and right pointers
            char leftChar = s[left];
            char rightChar = s[right];

            // Skip non-alphanumeric characters from the left side
            if (!char.IsLetterOrDigit(leftChar))
            {
                left++;
                continue;
            }

            // Skip non-alphanumeric characters from the right side
            if (!char.IsLetterOrDigit(rightChar))
            {
                right--;
                continue;
            }

            // If the characters at the left and right pointers don't match, return false
            if (leftChar != rightChar)
            {
                return false;
            }

            // Move the left pointer to the right and the right pointer to the left
            left++;
            right--;
        }

        // If the loop completes without returning false, the string is a palindrome
        return true;
    }
}
