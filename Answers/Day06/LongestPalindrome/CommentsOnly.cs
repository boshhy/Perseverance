// Overview
public class Solution
{
    public int LongestPalindrome(string s)
    {
        // This code calculates the length of the longest palindrome that can be formed using characters in the input string.
        // It iterates through the string, adding characters to a HashSet and removing them if they are encountered again, 
        // incrementing the palindrome length by 2. 
        // If there are unpaired characters, it adds one to the total length before returning it.
    }
}

// Comments
public class Solution
{
    public int LongestPalindrome(string s)
    {
        // Initialize a HashSet to store unique characters.
        // Initialize a variable to store the total length of the palindrome.
        // Iterate through each character in the input string.
        //     If the current character is already present in the HashSet.
        //         Increase the total length by 2 since this character can be part of the palindrome.
        //         Remove the current character from the HashSet since it's already used in the palindrome.
        //     If the current character is not present in the HashSet, add it.
        // If there are remaining characters in the HashSet after forming pairs, add 1 to the total length.

    }
}

// Pseudocode
public class Solution
{
    public int LongestPalindrome(string s)
    {
        // Create an empty HashSet called h
        // Create an integer variable called total and set it to 0

        // For each character letter in string s
        //     If h contains letter
        //         Increase total by 2
        //         Remove letter from h
        //     Else
        //         Add letter to h

        // Return total + 1 if h is not empty, otherwise return total
    }
}
