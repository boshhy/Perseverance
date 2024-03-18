// Overview
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // It checks whether the input array contains any duplicate elements by using a HashSet 
        // to keep track of unique numbers encountered. If a number is encountered that already exists in the HashSet, 
        // indicating a duplicate, the method returns true. Otherwise, if all elements are unique, it returns false.
    }
}

// Comments
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // Create a HashSet to store unique integers
        // Iterate through each element in the input array
        //     Attempt to add the current number to the HashSet; if it already exists, Add() returns false
        //         If the number already exists in the HashSet, return true indicating a duplicate is found
        // If the loop completes without finding any duplicates, return false
    }
}

// Pseudocode
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // uniqueNumbers = HashSet()

        // for each num in nums:
        //     if num is already in uniqueNumbers:
        //         return true
        //     else:
        //         add num to uniqueNumbers

        // return false
    }
}