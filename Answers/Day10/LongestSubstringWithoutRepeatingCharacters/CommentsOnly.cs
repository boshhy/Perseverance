// Overview
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        // The provided code aims to find the length of the longest substring within a given string "s" 
        // without any repeating characters. It employs a sliding window technique, using two pointers 
        // to track the current substring's start and end. By utilizing a HashSet to store unique characters, 
        // it efficiently identifies the longest substring without repetition, updating the maximum length encountered 
        // along the way. Finally, it returns the length of the longest non-repeating substring found in the input string.
    }
}

// Comments
public class Solution
{
    // This method calculates the length of the longest substring without repeating characters.
    public int LengthOfLongestSubstring(string s)
    {
        // Initialize variables to keep track of the maximum length, left pointer, and current length.
        // max - Maximum length of substring without repeating characters.
        // left - Left pointer of the current substring.
        // current - Length of the current substring without repeating characters.

        // HashSet to store characters of the current substring.

        // Loop through the string to find the longest substring without repeating characters.
        //     If the current character is already present in the HashSet, indicating repetition.
        //         Move the left pointer until the substring becomes unique again.
        //             Remove the leftmost character from the HashSet and update current length.
        //         Move the left pointer to the next character to continue the search.
        //         If the current character is unique, add it to the HashSet and update current length.
        //         Update the maximum length encountered so far.

        // Return the length of the longest substring without repeating characters.
    }
}

// Pseudocode
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        // Set max to 0
        // Set left to 0
        // Set current to 0
        // Create an empty HashSet called hashSet

        // For each character at index right in the string s
        //     If hashSet contains the character s[right]
        //         While the character at index left in s is not equal to s[right]
        //             Remove the character at index left from hashSet
        //             Increment left by 1
        //             Decrement current by 1
        //         Increment left by 1
        //     Else
        //         Increment current by 1
        //         Add the character s[right] to hashSet
        //         Set max to the maximum of max and current

        // Return max
    }
}