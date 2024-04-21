// Overview
public class Solution
{
    public string MinWindow(string s, string t)
    {
        // The provided code implements a method to find the minimum window in string 's' that contains all characters from string 't'. 
        // It initializes dictionaries to track the count of characters in 't' and the current window, sets initial values for the 
        // minimum window length and its starting index. The code then iterates through each character in 't', updating the dictionaries 
        // accordingly. Using a sliding window approach, it iterates through each character in 's', adjusting the window to find the 
        // minimum window containing all characters from 't'. 
        // Finally, it returns the minimum window found, or an empty string if no such window exists in 's'.
    }
}

// Comments
public class Solution
{
    // Method to find the minimum window in string s which contains all characters of string t
    public string MinWindow(string s, string t)
    {
        // Dictionary to store the total count of each character in string t
        // Dictionary to store the count of each character in the current window
        // Variable to store the minimum length of the window found so far
        // Variable to store the starting index of the minimum window found so far

        // Counting the occurrence of each character in string t and initializing the window dictionary

        // Variables to track the number of unique characters needed and the number of unique characters present in the window

        // Left pointer for the sliding window technique
        // Iterating through each character in string s to form a window
        //     If the current character is required in string t
        //         Increment the count of the current character in the window

        //         If the count of the current character in the window matches its count in string t, increment the number of unique characters found

        //         Adjust the window to find the minimum window satisfying the condition
        //                 Decrease the count of the leftmost character in the window

        //                 If the count of the leftmost character becomes less than its count in string t, decrement the count of unique characters found

        //                     If the current window size is smaller than the minimum window found so far, update the minimum window size and its starting index
        //             Move the left pointer to shrink the window

        // If no valid window is found, return an empty string

        // Return the substring of s containing the minimum window
    }
}

// Pseudocode
public class Solution
{
    public string MinWindow(string s, string t)
    {
        // Initialize empty dictionaries totalCharCountForT and window
        // Initialize minimumLengthSoFar to maximum possible integer value
        // Initialize leftLocation to -1

        // Iterate through each character in string t:
        //     If character exists in totalCharCountForT:
        //         Increment its count
        //     Else:
        //         Set its count to 1 in totalCharCountForT
        //         Set its count to 0 in window

        // Set need to the count of unique characters in totalCharCountForT
        // Set have to 0

        // Initialize left pointer to 0
        // Iterate through each character in string s:
        //     Get the current character at right pointer
        //     If the current character is required (exists in totalCharCountForT):
        //         Increment its count in window
        //         If the count of the current character in window matches its count in totalCharCountForT:
        //             Increment have

        //         While have equals need:
        //             Get the leftmost character in the window
        //             If the leftmost character exists in window:
        //                 Decrement its count in window
        //                 If its count becomes less than its count in totalCharCountForT:
        //                     Decrement have
        //                     If the current window size is smaller than minimumLengthSoFar:
        //                         Update minimumLengthSoFar to the current window size
        //                         Update leftLocation to the left pointer

        //             Move the left pointer to shrink the window

        // If no valid window is found:
        //     Return an empty string
        // Else:
        //     Return the substring of s starting from leftLocation with length minimumLengthSoFar  
    }
}
