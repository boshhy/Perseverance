// Overview
public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        // The FindAnagrams method in the Solution class detects all occurrences of anagrams of 
        // string p within string s. It initializes variables and a dictionary to track letter counts, 
        // then employs a sliding window technique to traverse s. During traversal, it adjusts the window 
        // based on letter occurrences and updates a counter for matched letters. When a full anagram 
        // match is detected, it records the starting index of the window. 
        // The method returns a list containing these indices as the result.
    }
}

// Comments
public class Solution
{
    // Method to find all anagrams of string p in string s
    public IList<int> FindAnagrams(string s, string p)
    {
        // Store the lengths of strings s and p

        // Initialize a list to store the indices of found anagrams

        // If the length of p is greater than the length of s, return empty result

        // Initialize indices for sliding window technique

        // Counter to keep track of the total letters matched

        // Dictionary to count the occurrences of each letter in string p

        // Populate the dictionary with the counts of each letter in string p

        // Sliding window technique to iterate through string s
        //     If the current character is found in string p and its count is greater than 0
        //         Decrement the count for the current character in p

        //         Increment total letters matched

        //         Move the right index of the window
        //     Else if the current character is found in p but its count is 0
        //         Increment the count for the character at the left index in p

        //         Decrement total letters matched

        //         Move the left index of the window
        //     Else, the current character is not found in p
        //         Move both left and right indices until they're equal
        //             Increment the count for the character at the left index in p

        //             Decrement total letters matched

        //             Move the left index
        //         Move both left and right indices to continue the iteration

        //     If all letters in p are matched, add the left index of the window to result

        // Return the list of indices of found anagrams
    }
}


// Pseudocode
public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        // sLength = length of string s
        // pLength = length of string p
        // result = empty list

        // if pLength > sLength:
        //     return result

        // leftIndex = 0
        // rightIndex = 0
        // totalLettersMatched = 0

        // pCount = empty dictionary

        // for each letter in p:
        //     if letter not in pCount:
        //         pCount[letter] = 0
        //     increment pCount[letter]

        // while rightIndex < sLength:
        //     if s[rightIndex] exists in pCount and pCount[s[rightIndex]] > 0:
        //         decrement pCount[s[rightIndex]]
        //         increment totalLettersMatched
        //         increment rightIndex
        //     else if s[rightIndex] exists in pCount:
        //         if s[leftIndex] exists in pCount:
        //             increment pCount[s[leftIndex]]
        //             decrement totalLettersMatched
        //         increment leftIndex
        //     else:
        //         while leftIndex < rightIndex:
        //             if s[leftIndex] exists in pCount:
        //                 increment pCount[s[leftIndex]]
        //                 decrement totalLettersMatched
        //             increment leftIndex
        //         increment leftIndex
        //         increment rightIndex

        //     if totalLettersMatched == pLength:
        //         add leftIndex to result

        // return result
    }
}

