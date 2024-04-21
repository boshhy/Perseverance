// Overview
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // The code first checks if the lengths of the input strings are equal;  
        // if not, it returns false as strings of different lengths cannot be anagrams. 
        // Then, it initializes an array to store the counts of each character's occurrence. 
        // It iterates through both strings, updating the character counts accordingly. 
        // After that, it verifies if all counts are zero, 
        // returning true if they are and false otherwise.
    }
}

// Comments
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // If the lengths of the two strings are not equal, they cannot be anagrams

        // Array to store the count of each character in the strings

        // Iterate through the characters of both strings
        //     Increment count for the character in string s and decrement count for the character in string t

        // Check if all counts are zero, indicating that both strings have the same characters with the same frequency
        //         If any count is not zero, the strings are not anagrams

        // If all counts are zero, the strings are anagrams so return true

    }
}

// Pseudocode
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // If the lengths of string s and string t are not equal, return false.
        // Create an array count of size 26 to store the count of characters.
        // Iterate over each character index i from 0 to length of string s - 1:
        //     a. Increment count of the character at index s[i] - 'a'.
        //     b. Decrement count of the character at index t[i] - 'a'.
        // Iterate over each total in the count array:
        //     a. If total is not equal to 0, return false.
        // Return true if all counts are zero, indicating that the strings are anagrams.
    }
}