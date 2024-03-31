// Overview
public class Solution
{
    public string LongestPalindrome(string s)
    {
        // This code finds the longest palindrome substring within a given string by iterating through each character and 
        // expanding around it to check for palindromes. It initializes starting and maxLength variables to keep track of 
        // the longest palindrome found. The IsPalindrome function is called with two pointers, which expand outward while 
        // checking if the substring between them is a palindrome. If a longer palindrome is found, starting and maxLength 
        // are updated accordingly. Finally, the substring with the longest palindrome is returned.
    }
}

// Comments
public class Solution
{
    public string LongestPalindrome(string s)
    {
        // Initialize variables to keep track of the starting index and maximum length of palindrome

        // Iterate through each character in the string
        //     Check for palindromes with the current character as the center (odd length palindrome)
        //     Check for palindromes with the current character and the next character as the center (even length palindrome)

        // Return the longest palindrome substring

        // Method to check if a substring is a palindrome, with given left and right indices
        //     Loop until left index is greater than or equal to 0 and right index is less than string length
        //         If characters at left and right indices match
        //             If the length of current palindrome substring is greater than the maximum length found so far
        //                 Update starting index and maximum length
        //             If characters don't match, break the loop (substring is not a palindrome)

        //         Move to the adjacent characters towards both ends
    }
}

// Pseudocode
public class Solution
{
    public string LongestPalindrome(string s)
    {
        // starting := 0
        // maxLength := 1

        // for index from 0 to length of s - 1:
        //     IsPalindrome(index, index)
        //     IsPalindrome(index, index + 1)

        // return substring of s starting from index 'starting' with length 'maxLength'

        // function IsPalindrome(left, right):
        //     while left >= 0 and right < length of s:
        //         if character at index 'left' of s equals character at index 'right' of s:
        //             if right - left + 1 > maxLength:
        //                 starting := left
        //                 maxLength := right - left + 1
        //         else:
        //             return
        //         decrement left
        //         increment right
    }
}
